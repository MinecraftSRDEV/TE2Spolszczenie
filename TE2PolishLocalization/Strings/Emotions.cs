using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TE2PolishLocalizationNamespace
{
    public static class Emotions
    {
        public static readonly Dictionary<string, string> Data = new Dictionary<string, string>
        {
            { "Text.Emote.ChipSpeech", "Łup tutaj!" },
            { "Text.Emote.CutSpeech", "Tnij tutaj!" },
            { "Text.Emote.DigSpeech", "Kop tutaj!" },
            { "Text.Emote.FightSpeech", "Walcz z nimi!" },
            { "Text.Emote.FollowSpeech", "Podążaj za mną!" },
            { "Text.Emote.HelloSpeech", "Witaj!" },
            { "Text.Emote.HelpSpeech", "Przydałaby się mała pomoc!" },
            { "Text.Emote.NotNowSpeech", "Nie teraz…" },
            { "Text.Emote.OKSpeech", "OK!" },
            { "Text.Emote.Sorry", "Przepraszam" },
            { "Text.Emote.SorrySpeech", "Przepraszam!" },
            { "Text.Emote.ThanksSpeech", "Dziękuję!" },
            { "Text.Emote.WaitSpeech", "Poczekaj tutaj!" },
            { "Text.Emote.Chip", "Kuć" },
            { "Text.Emote.Cut", "Ciąć" },
            { "Text.Emote.Dig", "Kopać" },
            { "Text.Emote.Fight", "Walka" },
            { "Text.Emote.Follow", "Podążaj" },
            { "Text.Emote.Hello", "Cześć" },
            { "Text.Emote.Help", "Pomoc" },
            { "Text.Emote.ItemNotEquipped", "Muszę najpierw wyposażyć $ItemToGet…" },
            { "Text.Emote.NotNow", "Nie teraz" },
            { "Text.Emote.OK", "OK" },
            { "Text.Emote.Surrender", "Poddaję się" },
            { "Text.Emote.SurrenderSpeech", "Poddaję się!" },
            { "Text.Emote.Thanks", "Dzięki" },
            { "Text.Emote.Wait", "Czekaj" },
        };

        public static readonly Dictionary<string, List<string>> Variants = new Dictionary<string, List<string>>
        {
            { "Text.Emote.ChipSpeech", new List<string> { "Kuj tutaj!" } },
            { "Text.Emote.CutSpeech", new List<string> { "Przetnij tutaj!" } },
            { "Text.Emote.DigSpeech", new List<string> { "Kop tutaj!" } },
            { "Text.Emote.FightSpeech", new List<string> { "Bij ich!" } },
            { "Text.Emote.FollowSpeech", new List<string> { "Za mną!" } },
            { "Text.Emote.HelloSpeech", new List<string> { "Cześć!", "Siema!", "Ooo, witaj!" } },
            { "Text.Emote.HelpSpeech", new List<string> { "Przydałaby się pomoc!", "Pomóż mi!", "Potrzebuję wsparcia!", "Ktoś może mi tu pomóc?!" } },
            { "Text.Emote.NotNowSpeech", new List<string> { "Nie teraz…" } },
            { "Text.Emote.OKSpeech", new List<string> { "OK!" } },
            { "Text.Emote.Sorry", new List<string> { "Przepraszam" } },
            { "Text.Emote.SorrySpeech", new List<string> { "Wybacz!", "Bardzo przepraszam!", "Sorki za to!" } },
            { "Text.Emote.ThanksSpeech", new List<string> { "Dzięki za to!", "Na zdrowie!", "Dzięki, stary!", "Dzięki, kumpel!", "Świetnie, dzięki!", "Dobra robota, dzięki!" } },
            { "Text.Emote.WaitSpeech", new List<string> { "Poczekaj tutaj!" } },
            { "Text.Interact.Kennel", new List<string> { "Schowaj się" } },
            { "Text.Interact.PeelPotatoes", new List<string> { "Obieraj ziemniaki" } },
            { "Text.Interact.Read", new List<string> { "Ucz się" } }
        };
    }
}
