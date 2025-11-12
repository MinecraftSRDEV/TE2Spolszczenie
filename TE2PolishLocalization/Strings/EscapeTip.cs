using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TE2PolishLocalizationNamespace
{
    public static class EscapeTip
    {
        public static readonly Dictionary<string, string> Data = new Dictionary<string, string>
        {
            { "Text.ClueHint.BOAT1.A", "PORADA UCIECZKI: Pomachaj na pożegnanie" },
            { "Text.ClueHint.BOAT1.B", "Nie przepadam za sportami wodnymi, ale jeśli nie boisz się zmoknąć, to coś dla ciebie!\\n\\nNa wschodniej burcie statku stoi skuter wodny, ale potrzebuje trochę miłości i napraw, by ruszyć.\\n\\nZbierz odpowiednie materiały i uciekaj stąd!" },
            { "Text.ClueHint.BOAT2.A", "PORADA UCIECZKI: Scuba Doo" },
            { "Text.ClueHint.BOAT2.B", "Oto plan, jeśli dasz radę go wykonać!\\n\\nPotrzebujesz kilku rzeczy, z których możesz stworzyć coś, co pozwoli ci oddychać pod wodą. Następnie udaj się na południową stronę statku i znajdź sposób, by się stąd wydostać!" },
            { "Text.ClueHint.BOAT3.A", "PORADA UCIECZKI: Mistrzowie Iluzji (porada dla wielu graczy!)" },
            { "Text.ClueHint.BOAT3.B", "Ryzykowna, ale nagradzająca ucieczka! Jeśli to czytasz, znaczy, że desperacko pragniesz wolności.\\n\\nNajpierw zdobądź materiały, by stworzyć atrapę broni palnej.\\n\\nGdy już ją masz, idź na wschód i... myślę, że sam się domyślisz, co dalej, gdy zobaczysz śmigłowiec..." },
            { "Text.ClueHint.PLANE1.A", "PORADA UCIECZKI: Samolotowy szał!" },
            { "Text.ClueHint.PLANE1.B", "Nie sugerowałbym tego, gdybym nie wierzył, że to możliwe.\\n\\nMusisz działać po cichu, by strażnicy cię nie zauważyli, podczas gdy szukasz potrzebnych przedmiotów. Z tego, co znajdziesz, możesz złożyć spadochron. Szalone, prawda?! Gdy już będziesz goowy, powiedzmy tylko, że nad i na prawo od startowych cel jest odpowiednie wyjście.\\n\\nPowodzenia!" },
            { "Text.ClueHint.PLANE2.A", "PORADA UCIECZKI: Paszport do wolności!" },
            { "Text.ClueHint.PLANE2.B", "Uważnie przeczytaj to, jeśli chcesz się stąd wydostać.\\n\\nBędziesz musiał być sprytny, przebiegły i odważny!\\n\\nKomputer sterujący samolotem znajduje się na północy maszyny.\\n\\nMusisz znaleźć sposób, by wpłynąć na jego działanie i przyspieszyć swoją ucieczkę!" },
            { "Text.ClueHint.PLANE3.A", "PORADA UCIECZKI: Lotne plany (porada dla wielu graczy!)" },
            { "Text.ClueHint.PLANE3.B", "Widziałeś kiedyś ten film… a może teraz nie czas o tym gadać. W ładowni samolotu znajduje się coś interesującego, co może pomóc ci w ucieczce.\\n\\nIdź i przekonaj się sam!" },
            { "Text.ClueHint.TRAIN1.A", "PORADA UCIECZKI: Uzależniony od ciebie" },
            { "Text.ClueHint.TRAIN1.B", "Głupi Bobbi miał jeszcze głupszy pomysł — że z odpowiednimi narzędziami zrobi hak wspinaczkowy, wdrapie się na dach wagonu i zaczepi się o przejeżdżającą konstrukcję, by uciec.\\n\\nPodobno ten szaleniec naprawdę to zrobił… ale kto wie!" },
            { "Text.ClueHint.TRAIN2.A", "PORADA UCIECZKI: Mój mały szelma" },
            { "Text.ClueHint.TRAIN2.B", "Kiedyś rozmawiałem z Szaloną Jo — słynną więźniarką, która twierdziła, że konie łatwo da się oszukać, jeśli tylko ma się odpowiednie środki.\\n\\nNa pytanie o szczegóły, tylko mamrotała pod nosem coś o sztucznych marchewkach... Taka już jest Szalona Jo!" },
            { "Text.ClueHint.TRAIN3.A", "PORADA UCIECZKI: Luźny wagon (porada dla wielu graczy!)" },
            { "Text.ClueHint.TRAIN3.B", "Słuchaj uważnie — jeśli zdobędziesz kilka łomów i pójdziesz do zachodniego wagonu, możesz mieć szansę odpiąć go i uciec.\\n\\nTylko upewnij się, że stoisz na właściwym wagonie, gdy to zrobisz! Powodzenia!" },

            { "Text.PayphoneHint.AREA1.A", "PODPOWIEDŹ UCIECZKI: Technologia obcych… (wskazówka multiplayer!)" },
            { "Text.PayphoneHint.AREA1.B", "Kiedyś podsłuchałem plotki od szefów… W jednym z hangarów ma być UFO albo coś w tym rodzaju.\\n\\nNie działa od dawna… Wyobraź sobie, gdyby dało się to uruchomić! Może sprawdź zestaw do lądowania na Księżycu… Albo coś przydatnego…" },
            { "Text.PayphoneHint.AREA2.A", "PODPOWIEDŹ UCIECZKI: Ukryte na widoku…" },
            { "Text.PayphoneHint.AREA2.B", "Ci szaleńcy pilnujący tej bazy myślą, że wiedzą, jak nas zatrzymać.\\n\\nHah! Mało wiedzą.\\n\\nZ odpowiednimi narzędziami możesz się przebrać i podszyć pod jednego z tych niekumających technologicznie…\\n\\nBędziesz potrzebować przepustki od strażników, a podobno konserwator trzyma zapasowe ubrania w swoim biurku. Dopiero wtedy możesz wyjść przez recepcję na południowy zachód… Może?" },
            { "Text.PayphoneHint.CP3.A", "PODPOWIEDŹ UCIECZKI: Poznaj załogę" },
            { "Text.PayphoneHint.CP3.B", "W tych okolicach możesz zobaczyć kilku obcych filmujących nas i nasze więzienne życie.\\n\\nZ odpowiednim strojem możesz porzucić więzienne ubranie i wtopić się w cywilów.\\n\\nMając to na uwadze, powinieneś móc wyjść przez północne wyjście strzeżone!" },
            { "Text.PayphoneHint.DIC1.A", "PODPOWIEDŹ UCIECZKI: Do helikoptera! (wskazówka multiplayer!)" },
            { "Text.PayphoneHint.DIC1.B", "Uważaj na współpracownika dyrektora… Przylatuje helikopterem na dach. Nie próbowałbym niczego z tym helikopterem bez uzbrojenia…\\n\\nAlbo przynajmniej wyglądaj, jakbyś był uzbrojony!" },
            { "Text.PayphoneHint.DIC2.A", "PODPOWIEDŹ UCIECZKI: Zimna sprawa Część 1" },
            { "Text.PayphoneHint.DIC2.B", "Dawno temu jeden z więźniów sugerował, że jedynym sposobem na ucieczkę byłoby w worku na ciało.\\n\\nDopiero gdy ostatecznie opuścili to miejsce, zrozumiałem, co mieli na myśli.\\n\\nTo niezwykle ryzykowne, ale jeśli jesteś gotów spowolnić tętno za pomocą lodu… to jesteś gotów umrzeć… albo udawać, że umierasz…" },
            { "Text.PayphoneHint.DIC3.A", "PODPOWIEDŹ UCIECZKI: Zimna sprawa Część 2" },
            { "Text.PayphoneHint.DIC3.B", "Jak mówiłem, udawanie własnej śmierci jest ryzykownym sposobem, ale jeśli zdobędziesz potrzebne przedmioty, możesz stworzyć ostatni element układanki i się stąd wydostać.\\n\\nMiejsce? Udaj się do izby chorych na wschód od kompleksu.\\n\\nDo zobaczenia po drugiej stronie, towarzyszu!" },
            { "Text.PayphoneHint.GU1.A", "PODPOWIEDŹ UCIECZKI: Młot skalny w trudnym miejscu!" },
            { "Text.PayphoneHint.GU1.B", "Krąży plotka, że jeden z więźniów potrafi zdobyć wszystko. I to naprawdę wszystko!\\n\\nFast Eddie był gościem, którego znałem, i próbował zdobyć Młot Skalny. Miał szalony plan, żeby wydostać się przez system kanalizacyjny.\\n\\nMyślałem, że jest szalony… Ech, tęsknię za Fast Eddiem." },
            { "Text.PayphoneHint.OIL1.A", "PODPOWIEDŹ UCIECZKI: Pływanie z delfinami" },
            { "Text.PayphoneHint.OIL1.B", "Jakiś szaleniec twierdził, że zaprzyjaźnił się z delfinem przy wodzie.\\n\\nMówił, że nawiązali jakąś więź… Jak to w ogóle działa – czy człowiek może mówić po „delfinie”?" },
            { "Text.PayphoneHint.OIL2.A", "PODPOWIEDŹ UCIECZKI: Gadaj śmieciami" },
            { "Text.PayphoneHint.OIL2.B", "Kiedyś ktoś podsłuchał absurdalny pomysł na ucieczkę.\\n\\nMówił, że jeśli uda Ci się przebrać przy punkcie odbioru śmieci… zabiorą Cię stąd!\\n\\nBzdura, jeśli mnie pytasz!" },
            { "Text.PayphoneHint.POW1.A", "PODPOWIEDŹ UCIECZKI: Ślizg do zwycięstwa… (wskazówka multiplayer!)" },
            { "Text.PayphoneHint.POW1.B", "Jeden z więźniów był przekonany, że po prostu „odleci” z tego więzienia.\\n\\nMiał wizję w śnie, że zbuduje samolot… albo jakiś szybowiec z dostępnych materiałów.\\n\\nHeh, tutaj nawet czas nie 'leci'! Szaleniec!\\n\\nPolecam start z najwyższego punktu zamku!" },
            { "Text.PayphoneHint.POW2.A", "PODPOWIEDŹ UCIECZKI: Speed McQueen" },
            { "Text.PayphoneHint.POW2.B", "Na południowy zachód od kompleksu jest budynek ze środkiem transportu jednego ze strażników.\\n\\nTrochę zaniedbany, ale z odpowiednimi narzędziami możesz wykorzystać tę potencjalnie szybką maszynę, żeby stąd wyjść!" },
            { "Text.PayphoneHint.SPA1.A", "PODPOWIEDŹ UCIECZKI: Wyścig z kosmosu…" },
            { "Text.PayphoneHint.SPA1.B", "Od lat ludzkość marzy o podboju kosmosu… Ale nie w ten sposób. Znam miejsce sterowania grawitacją, które da Ci przewagę.\\n\\nAby dostać się do sterowania grawitacją, musisz udać się do gabinetu dyrektora. Potem użyj czegoś napędzanego, np. Jetpacku… Może uda Ci się zdobyć jeden w kwaterach strażników na wschodzie więzienia!" },
            { "Text.PayphoneHint.SPA2.A", "PODPOWIEDŹ UCIECZKI: Groszek w strąku! (wskazówka multiplayer!)" },
            { "Text.PayphoneHint.SPA2.B", "Jeden z serwisowych droidów był podsłuchany, jak gadał o zepsutym statku kosmicznym.\\n\\nZnajduje się na północny wschód od więzienia, tam jest serwis pojazdów.\\n\\nJeśli tam pójdziesz, powinieneś zorientować się, jak go naprawić!" },
            { "Text.PayphoneHint.WW1.A", "PODPOWIEDŹ UCIECZKI: Zapinanie linki!" },
            { "Text.PayphoneHint.WW1.B", "Hej! Jak tam w środku, radzisz sobie? Mam dla Ciebie ciekawą informację.\\n\\nKiedyś więzień 'Stringer' powiedział, że jeśli znajdzie sposób, by strzelać liną z północnego budynku, mógłby zjechać na linie na zewnątrz. Do dziś nikt nie wie, czy mu się udało.\\n\\nNie lubił hałasu, ale jakiż on potrafił jeść!" },
            { "Text.PayphoneHint.WW3.A", "Niejasna wskazówka (Dziki Zachód)" },
            { "Text.PayphoneHint.WW3.B", "To jest pełna wskazówka, którą zakupiłeś." },
        };
    }
}
