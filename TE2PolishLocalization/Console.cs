using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace TE2PolishLocalizationNamespace
{
    public class DebugConsole : MonoBehaviour
    {
        private bool showConsole = false;
        private static List<string> consoleLog = new List<string>();
        private static Vector2 scrollPosition = Vector2.zero;
        private static float textRect = 0f;

        private string lastLog = "";

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                showConsole = !showConsole;
            }
        }

        private void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }

        private void HandleLog(string logString, string stackTrace, LogType type)
        {
            switch (type)
            {
                case LogType.Log:
                    {
                        consoleLog.Add("INFO: " + logString);
                        scrollPosition.y = textRect;
                        break;
                    }
                case LogType.Warning:
                    {
                        consoleLog.Add("WARN: " + logString);
                        scrollPosition.y = textRect;
                        break;
                    }
                case LogType.Error:
                    {
                        consoleLog.Add("ERRO: " + logString);
                        scrollPosition.y = textRect;
                        break;
                    }
                case LogType.Exception:
                    {
                        consoleLog.Add("EXCP: " + logString);
                        scrollPosition.y = textRect;
                        break;
                    }
                default:
                    {
                        consoleLog.Add("INFO: " + logString);
                        scrollPosition.y = textRect;
                        break;
                    }
            }
        }

        private void OnGUI()
        {
            if (!showConsole)
            {
                return;
            }

            GUI.Box(new Rect(10, 10, Screen.width - 20, Screen.height / 3), "Debug Console");

            textRect = 0f;
            scrollPosition = GUI.BeginScrollView(new Rect(15, 40, Screen.width - 30, Screen.height / 3 - 80), scrollPosition, new Rect(0, 0, Screen.width - 50, consoleLog.Count * 20));
            for (int i = 0; i < consoleLog.Count; i++)
            {
                GUI.Label(new Rect(5, i * 20, Screen.width - 100, 20), consoleLog[i]);
                textRect += (i * 20);
            }
            GUI.EndScrollView();
        }
    }
}
