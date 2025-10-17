using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class TE2Patcher
{
    private enum translationStatus
    {
        installed,
        notInstalled,
        notReferenced,
        noDll,
        noExecutable,
        noAssembly,
        NONE
    }

    public static string executablePath = "";
    public static string managedPath = "";
    public static string assemblyPath = "";
    public static string backupPath = "";

    private static bool checkIfIsReferenced(string asmPath)
    {
        try
        {
            byte[] data = File.ReadAllBytes(asmPath);
            Assembly asm = Assembly.Load(data);

            foreach (AssemblyName reference in asm.GetReferencedAssemblies())
            {
                if (reference.Name == "TE2PolishLocalization") return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return false;
    }
    private static bool checkIfIsInstalled(string path)
    {
        if (File.Exists(path)) return true;
        return false;
    }
    private static translationStatus checkGameFolder(string path)
    {
        executablePath = path + "/TheEscapists2.exe";
        managedPath = path + "TheEscapists2_Data/Managed";
        assemblyPath = path + "TheEscapists2_Data/Managed/Assembly-CSharp.dll";

        if (File.Exists(executablePath))
        {
            if (File.Exists(assemblyPath))
            {
                bool flag1 = checkIfIsReferenced(assemblyPath);
                bool flag2 = checkIfIsInstalled(managedPath + "/TE2PolishLocalization.dll");

                if (!flag1 && !flag2)
                {
                    return translationStatus.notInstalled;
                }
                if (flag1 && flag2)
                {
                    return translationStatus.installed;
                }
                if (flag1 && !flag2)
                {
                    return translationStatus.noDll;
                }
                if (flag2 && !flag1)
                {
                    return translationStatus.notReferenced;
                }
            }
            else
            {
                return translationStatus.noAssembly;
            }
        }
        else
        {
            return translationStatus.noExecutable;
        }

        return translationStatus.notInstalled;
    }

    private string getGameFolderManually()
    {
        return "";
    }

    private static bool install()
    {
        backupPath = backupPath + ".bak";

        if (!File.Exists(backupPath))
            File.Copy(assemblyPath, backupPath);

        var resolver = new DefaultAssemblyResolver();
        resolver.AddSearchDirectory(Path.GetDirectoryName(assemblyPath));

        var readerParams = new ReaderParameters { AssemblyResolver = resolver, ReadSymbols = false };

        // --- Wczytaj główne assembly z pamięci (nie blokuje pliku na dysku) ---
        byte[] mainBytes = File.ReadAllBytes(assemblyPath);
        Mono.Cecil.AssemblyDefinition assembly;

        var ms = new MemoryStream(mainBytes);
        
        assembly = Mono.Cecil.AssemblyDefinition.ReadAssembly(ms, readerParams);
        // NOTE: nie zamykamy assembly tutaj — AssemblyDefinition trzyma swoje własne dane,
        // ale strumień już zwolniliśmy (ReadAssembly skopiował potrzebne dane).
        

        //var readerParams = new ReaderParameters { AssemblyResolver = resolver };
        //var assembly = Mono.Cecil.AssemblyDefinition.ReadAssembly(assemblyPath, readerParams);
        var module = assembly.MainModule;

        File.Copy(removeFromPath(Assembly.GetEntryAssembly().Location.ToString()) + "/TE2PolishLocalization.dll", managedPath + "/TE2PolishLocalization.dll");
        var bridgePath = Path.Combine(Path.GetDirectoryName(assemblyPath), "TE2PolishLocalization.dll");
        var bridgeAsm = Mono.Cecil.AssemblyDefinition.ReadAssembly(bridgePath);
        var bridgeType = bridgeAsm.MainModule.Types.First(t => t.Name == "CustomLocalization");
        var loadMethod = bridgeType.Methods.First(m => m.Name == "Load");

        var imported = module.ImportReference(loadMethod);

        var targetType = module.Types.First(t => t.Name == "Boot" || t.Name == "Bootstrap");
        var targetMethod = targetType.Methods.First(m => m.Name == "Start" || m.Name == "Awake");

        var il = targetMethod.Body.GetILProcessor();
        var firstInstr = targetMethod.Body.Instructions[0];

        il.InsertBefore(firstInstr, il.Create(Mono.Cecil.Cil.OpCodes.Call, imported));
        

        assembly.Write(assemblyPath + "_patched.dll");

        if (File.Exists(assemblyPath + "-orginal"))
        {
            File.Delete(assemblyPath + "-orginal");
        }
        if (File.Exists(assemblyPath + "_patched.dll"))
        {
            File.Move(assemblyPath, assemblyPath + "-orginal");
            File.Move(assemblyPath + "_patched.dll", assemblyPath);
        }

        return true;
    }

    private static void uninstall()
    {
        if (File.Exists(assemblyPath + "-orginal"))
        {
            try
            {
                File.Delete(assemblyPath);
            }
            catch { }
            try
            {
                File.Delete(managedPath + "/TE2PolishLocalization.dll");
            }
            catch { }
            File.Move(assemblyPath + "-orginal", assemblyPath);
        }
    }

    private static string removeFromPath(string input)
    {
        return input.Replace("TE2AssemblyPatcher.dll", "");
    }

    public static void Pause()
    {
        Console.Write("Naciśnij dowolny przycisk by kontynuować . . . ");
        Console.ReadKey(true);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Instalator spolszczenia do gry The Escapists 2");
        Console.WriteLine("==============================================================");
        Console.WriteLine("Spolszczenie przygotował MCSR (MinecraftSRDEV)\n");
        Console.WriteLine("Więcej moich projektów na githubie: github.com/MinecraftSRDEV");
        Console.WriteLine("==============================================================");

        string gameDir = "";

        if (args.Length < 1)
        {
            string getPath = Assembly.GetEntryAssembly().Location.ToString();
            gameDir = removeFromPath(getPath);
        }
        else
        {
            gameDir = args[0];
            backupPath = gameDir;

            Console.WriteLine("Podano ścierzkę gry.");
        }

        translationStatus currentStatus = checkGameFolder(gameDir);

        switch (currentStatus)
        {
            case translationStatus.notInstalled:
                {
                    Console.WriteLine("Wszystko się zgadza. Można instalować [T/N]: ");
                    while (true)
                    {
                        string sel = Console.ReadLine();

                        if (sel == "T" || sel == "t")
                        {
                            if (install())
                            {
                                Console.WriteLine("Patch zakończony sukcesem!");
                            }
                            break;
                        }
                        else if (sel == "N" || sel == "n")
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    Pause();
                    break;
                }
            case translationStatus.installed:
                {
                    Console.WriteLine("Spolszczenie jest już zainstalowane. Odinstalować [T/N]: ");
                    while (true)
                    {
                        string sel = Console.ReadLine();

                        if (sel == "T" || sel == "t")
                        {
                            uninstall();
                            break;
                        }
                        else if (sel == "N" || sel == "n")
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    Pause();
                    break;
                }
            case translationStatus.notReferenced:
                {
                    Console.WriteLine("Nie można kontynuować instalacji: Brak referencji do biblioteki lokalizacji.");
                    Pause();
                    break;
                }
            case translationStatus.noDll:
                {
                    Console.WriteLine("Nie można kontynuować instalacji: Brak biblioteki lokalizacji.");
                    Pause();
                    break;
                }
            case translationStatus.noExecutable:
                {
                    Console.WriteLine("Nie można kontynuować instalacji: Brak pliku wykonywalnego gry. Instalator może nie być w dobrym miejscu.");
                    Pause();
                    break;
                }
            case translationStatus.noAssembly:
                {
                    Console.WriteLine("Nie można kontynuować instalacji: Brak pliku assembly. Instalator może nie być w dobrym miejscu.");
                    Pause();
                    break;
                }
        }
    }
}
