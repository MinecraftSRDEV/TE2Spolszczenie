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

            Debug.Log("Localization loaded");
        }

        private static GameObject consoleObject;
        private static GameObject localizatorObject;
    }
}
