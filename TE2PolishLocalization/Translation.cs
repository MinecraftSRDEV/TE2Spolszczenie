using NodeCanvas.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using static AkTriggerBase;
using static System.Net.Mime.MediaTypeNames;

namespace TE2PolishLocalizationNamespace
{
    public static class Content
    {
        static Dictionary<string, string> Merge(params Dictionary<string, string>[] dicts)
        {
            var result = new Dictionary<string, string>();
            foreach (var d in dicts)
                foreach (var kv in d)
                    result[kv.Key] = kv.Value;
            return result;
        }

        static Dictionary<string, List<string>> Merge2(params Dictionary<string, List<string>>[] dicts)
        {
            var result = new Dictionary<string, List<string>>();
            foreach (var d in dicts)
                foreach (var kv in d)
                    result[kv.Key] = kv.Value;
            return result;
        }

        public static readonly Dictionary<string, string> Data = Merge(Cutscenes.Data, Editor.Data, Emotions.Data, EscapeMethods.Data, EscapeTip.Data, Interface.Data, Items.Data, LoadingTips.Data, Map.Data, Menu.Data, Other.Data, Quests.Data, Speech.Data, Tutorial.Data, Prisons.Data);

        public static readonly Dictionary<string, List<string>> Varianted = Merge2(Emotions.Variants, LoadingTips.Variants, Quests.Variants, Speech.Variants);
    }
}
