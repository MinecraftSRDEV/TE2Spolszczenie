using UnityEngine;
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NodeCanvas.Tasks.Actions;
using System.Reflection;
using ParadoxNotion.Serialization.FullSerializer;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;
using NodeCanvas.Framework;
using static LevelSetup_LightPlacer;
using System.Collections;

namespace TE2PolishLocalizationNamespace
{
    public class Localize : MonoBehaviour
    {
        private string UnescapeString(string str)
        {
            return str
                .Replace("\\n", "\n")
                .Replace("\\r", "\r")
                .Replace("\\t", "\t")
                .Replace("\\\\", "\\");
        }

        private void TryToPatch()
        {
            try
            {
                Debug.Log("Langpack zawiera: " + Content.Data.Count);
                Type locType = typeof(Localization);
                FieldInfo fTable = locType.GetField("m_StringTable",
                    BindingFlags.NonPublic | BindingFlags.Static);
                var dict = (Dictionary<string, string[]>)fTable.GetValue(null);

                Debug.Log($"[PL] Odnaleziono m_StringTable: {dict.Count} wpisów");

                foreach (var kvp in dict)
                {
                    if (Content.Data.ContainsKey(kvp.Key))
                    {
                        try
                        {
                            kvp.Value[1] = UnescapeString(Content.Data[kvp.Key]);
                        }
                        catch (Exception e)
                        {
                            Debug.LogError("Problem z nadpisaniem wartości");
                        }
                    }
                    else
                    {
                        Debug.LogWarning("Gra nie zawiera klucza:" + kvp.Key.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Debug.LogError("[PL] Błąd podczas dostępu do lokalizacji: " + e.ToString());
            }

            try
            {
                Type locType = typeof(Localization);

                // pobierz tablicę języków (żeby znać długość i indeks polskiego)
                FieldInfo langField = locType.GetField("m_Languages", BindingFlags.NonPublic | BindingFlags.Static);
                string[] languages = (string[])langField.GetValue(null);

                int langCount = languages.Length;
                int polishIndex = 1;

                // słownik i typ wariantów
                FieldInfo fVarTable = locType.GetField("m_StringVariantTable", BindingFlags.NonPublic | BindingFlags.Static);
                object tableObj = fVarTable.GetValue(null);
                Type variantType = locType.GetNestedType("StringVariants", BindingFlags.NonPublic);
                Type dictType = typeof(Dictionary<,>).MakeGenericType(typeof(string), variantType);

                MethodInfo tryGetValue = dictType.GetMethod("TryGetValue");
                MethodInfo addMethod = dictType.GetMethod("Add");
                PropertyInfo indexer = dictType.GetProperty("Item");
                FieldInfo stringsField = variantType.GetField("strings", BindingFlags.Public | BindingFlags.Instance);

                int replaced = 0;

                foreach (var kv in Content.Varianted)
                {
                    string key = kv.Key;
                    List<string> variants = kv.Value;

                    // utwórz nowy obiekt StringVariants
                    object stringVariants = Activator.CreateInstance(variantType);
                    var list = (IList)stringsField.GetValue(stringVariants);

                    foreach (var text in variants)
                    {
                        string[] arr = new string[langCount];
                        arr[polishIndex] = UnescapeString(text); // wpisz tłumaczenie w odpowiedni indeks
                        list.Add(arr);
                    }

                    // nadpisz istniejący wpis lub dodaj nowy
                    object[] args = new object[] { key, null };
                    bool exists = (bool)tryGetValue.Invoke(tableObj, args);

                    indexer.SetValue(tableObj, stringVariants, new object[] { key });

                    replaced++;
                }

                Debug.Log($"[PL] Załadowano {replaced} wariantów z pełnymi tablicami językowymi.");
            }
            catch (Exception ex)
            {
                Debug.LogError($"[PL] Błąd podczas ładowania wariantów: {ex}");
            }
        }

        private void Start()
        {
            TryToPatch();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                TryToPatch();
            }
        }

        private Dictionary<string, string> texts = new Dictionary<string, string>();
    }

    public class CustomLocalization
    {
        public static void Load()
        {
            CustomLocalization.consoleObject = new GameObject("Console");
            CustomLocalization.consoleObject.AddComponent<DebugConsole>();
            UnityEngine.Object.DontDestroyOnLoad(CustomLocalization.consoleObject);

            Debug.Log("Debug console loaded");

            CustomLocalization.localizatorObject = new GameObject("Localizator");
            CustomLocalization.localizatorObject.AddComponent<Localize>();
            UnityEngine.Object.DontDestroyOnLoad(CustomLocalization.localizatorObject);

            Debug.Log("Localization " + VERSION.ToString() + " loaded");
        }

        public static string VERSION = "1.1";

        private static GameObject consoleObject;
        private static GameObject localizatorObject;
    }
}
