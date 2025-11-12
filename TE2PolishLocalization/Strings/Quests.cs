using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TE2PolishLocalizationNamespace
{
    public static class Quests
    {
        public static readonly Dictionary<string, string> Data = new Dictionary<string, string>
        {
            { "Text.Quest.DeliveryDriver.Desc", "Słyszałem, że kiedyś byłeś kierowcą dostaw na zewnątrz?\\n\\nTo wygodne, bo… co ty mówisz? Źle usłyszałem? Szkoda...\\n\\nMógłbyś udawać? Mam kilka zamówień dla klientów…" },
            { "Text.Quest.Freeman", "Młot skalny w trudnym miejscu" },
            { "Text.Quest.Freeman.Desc", "Powiedz… zacznij tylko, jeśli zamierzasz dojść do końca.\\n\\nJeśli wybierzesz tę ścieżkę, mogę Ci pomóc.\\n\\nMoże zdobądź dla mnie trochę literatury?" },
            { "Text.Quest.Freeman.Desc1", "Wow… Jestem pod wrażeniem. Może zdobądź coś małego z $ItemSpawnLocation?" },
            { "Text.Quest.Freeman.Desc2", "Strażnicy obserwują mnie po incydencie z książką - więc potrzebuję Twojej pomocy!\\n\\nZbierz coś dla mnie, dobrze?\\n\\nNajlepiej spuszczaj to w toalecie po zdobyciu z $ItemLocation." },
            { "Text.Quest.Freeman.Desc3", "Martwię się o innych więźniów\\n\\nChcą mi zaszkodzić, ale jestem już za stary na tradycyjny pojedynek.\\n\\nCzy mógłbyś zrobić coś, bym mógł się chronić?" },
            { "Text.Quest.Freeman.Desc4", "Nawet z tą bronią martwię się o paru więźniów.\\n\\nWyglądasz silny… i muskularny!\\n\\nCzy mógłbyś zadać komuś ból za mnie?" },
            { "Text.Quest.Freeman.Desc5", "Dobrze zrobiłeś. Naprawdę dobrze.\\n\\nProblem jest taki, że ich współpracownik poluje na mnie.\\n\\nMuszę się go pozbyć!" },
            { "Text.Quest.Freeman.Desc6", "Dzięki za pomoc… Cała ta ciężka praca sprawia, że mam ochotę na dobrą lekturę!\\n\\nMoże zdobądź dla mnie książkę, przyjacielu?" },
            { "Text.Quest.Freeman.Desc7", "To źle, BARDZO źle.\\n\\nWiesz, kiedy pobiłeś paru więźniów? No cóż… Jeden z strażników się o tym dowiedział.\\n\\nWiesz, co teraz zrobić, prawda?" },
            { "Text.Quest.Freeman.Desc8", "Chciałbym się stąd wydostać, ale jestem za stary.\\n\\nMam ostatnią prośbę: jeśli dostarczysz mi broń z prawdziwym 'pazurem', poczekam na nich.\\n\\nZrób to dla mnie, a dam Ci bilet na wolność!" },
            { "Text.Quest.Freeman.FirstObjective", "Zdobyj $ItemToGet" },
            { "Text.Quest.Freeman.SecondObjective", "Zdobyj $ItemToGet" },
            { "Text.Quest.Freeman.ThirdObjective", "Pozbądź się $ItemToDestroy" },
            { "Text.Quest.Snooty.Desc", "Eek…. Klik! Eeeek, Eeek, Klik… Klik… Eek, Eeeek!, Klik, Klik…. Eeek!" },
            { "Text.Quest.Snooty.Desc1", "Ryba jest super, ale lubimy słodycze. Jak masz nogi - przynieś mi ciasto, przyjacielu!" },
            { "Text.Quest.ArtsAndCrafts.Desc", "Jesteś zręczny, prawda?\\n\\nKiedy znajdziesz czas, możesz mi zrobić $ItemToCraft?" },
            { "Text.Quest.BeatTheBully.Desc", "$CombatTarget był stałym kłopotem od momentu, kiedy tu przybyłem. Mam dość ciągłego patrzenia za siebie i bycia ofiarą! Czas na działanie!" },
            { "Text.Quest.DayAtTheSpa.Desc", "Mój przyjaciel $DeliverTo potrzebuje ostatniego elementu na nadchodzący „Dzień w SPA”.\\n\\nCzy możesz mi zrobić $ItemToCraft? Byłoby to miły prezent dla niego!" },
            { "Text.Quest.Discredit.Desc", "Mój przyjaciel $DeliverItemTo ma w przyszłym tygodniu spotkanie z komisją warunkowego zwolnienia. Będę bardzo samotni, gdyby się wyjechał!\\n\\nMożna to jednak uniknąć, jeśli umieścisz $ItemToGet w jego biurku…" },
            { "Text.Quest.Discredit.FirstObjective", "Umieść $ItemToGet w biurku $DeliverItemTo" },
            { "Text.Quest.FashionVictim.Desc", "Muszę zrobić duże wrażenie na spotkaniu warunkowego zwolnienia w przyszłym tygodniu, jeśli chcę wcześniejsze wyjście.\\n\\nCzy możesz mi znaleźć $ItemToGet? Zamierzam rozbłysnąć…" },
            { "Text.Quest.IchLeibeKunst.Desc", "Zazdrość znów mnie uderzyła!\\n\\nJakiś głupiec wypchał wszystkie moje materiały malarskie do toalety, oczywiście z zazdrości moich niesamowitych umiejętności artystycznych!\\n\\nCzy możesz pomóc mi znaleźć nowe?" },
            { "Text.Quest.LocationLocationLocation.Desc", "Kumpel przygotował dla mnie skrytę – prezent $ItemToGet w $ItemSpawnLocation.\\n\\nMożesz go odebrać? Jestem zajęty relaksowaniem się, widzisz…" },
            { "Text.Quest.Locksmith.Desc", "$ItemToCraft2 przyspieszyłby mi ucieczkę.\\n\\nCzy możesz to zrobić?" },
            { "Text.Quest.LostProperty.Desc", "Ten $ItemToGet miał wartość sentymentalną, a ja go zgubiłem!\\n\\nJeśli go znalazłeś, będę wdzięczny." },
            { "Text.Quest.P45.Desc", "$JobTarget nie radzi sobie z tą pracą – zrobił z tego prawdziwy bałagan!\\n\\nW interesie wszystkich byłoby, gdyby został zwolniony." },
            { "Text.Quest.SickNote.Desc", "Ta straszna choroba mnie osłabia, a moji wrogowie w pełni z niej korzystają!\\n\\nMuszę wrócić do formy, czy możesz mi znaleźć $ItemToGet?" },
            { "Text.Quest.SickNote.Name", "Zgłoszenie chorobowe" },
            { "Text.Quest.StolenGoods.Desc", "$ItemSpawnLocation wpił swoje brudne pazury w mój biurko i odciął mi $ItemToGet!\\n\\nZapłaciłem za to dużo, a chcę go natychmiast odzyskać!" },
            { "Text.Quest.TheArmsDealer.Desc", "Planem jest wywalczyć kilka ciężkich uderzeń w ciągu najbliższych dni i oczyścić listę moich przeciwników.\\n\\nBędę potrzebował dobrych broni, aby to zrobić – chcesz mi pomóc zdobyć je?" },
            { "Text.Quest.TheBeatdown.Desc", "$CombatTarget pokazał swoje prawdziwe oblicze i zdradził mnie strażnikom. Zniszcz ich!" },
            { "Text.Quest.TheChef.Desc", "Zdobądź dla mnie $ItemToGet, by wygnąć mój głód, czy możesz?" },
            { "Text.Quest.TheConductor.Desc", "Ja i zespół mamy album do ukończenia, ale niektóre talentowe hakery wyrzuciły nasze instrumenty w dół rury!\\n\\nZespół bez instrumentów to nic… Czy pomożesz nam?" },
            { "Text.Quest.TheDistraction.Desc", "Ze względu na powody, których nie będę wyjaśniać, nie mogę być widziany podczas następnego $RuckusType.\\n\\nZorganizuj scenę i zapłacę Ci dobrze." },
            { "Text.Quest.TheMule.Desc", "$ItemToGet jest prezentem dla $DeliverItemTo, ale nie chcę, żeby wiedzieli, że to od mnie jeszcze.\\n\\nCzy możesz?" },
            { "Text.Quest.TheSuckUp.Desc", "Wydarzyło się – dostałem telefon! Wygląda na to, że awans w końcu jest na horyzoncie.\\n\\nMuszę wyprać moje $Uniform na tę okazję." },
            { "Text.Quest.TheWetBandit.Desc", "Chciałbym zobaczyć wyraz twarzy $FloodTarget, jeśli zalewesz ich toalety.\\n\\nBędzie bezcenne!" },
            { "Text.Quest.WasteManagement.Desc", "$ItemToDestroy łączy mnie z wydarzeniem, które mogłoby sprawić mi sporo kłopotów!\\n\\nZrób szlachetny czyn – zniszcz to za mnie!" },
            { "Text.Quest.ArtsAndCrafts.FirstObjective", "Wytwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.ArtsAndCrafts.Name", "Zróbmy coś!" },
            { "Text.Quest.BeatTheBully.FirstObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.BeatTheBully.Name", "Pokonaj Bulleya" },
            { "Text.Quest.BeatTheBully.SecondObjective", "Zaatakuj $CombatTarget z użyciem $ItemToCraft" },
            { "Text.Quest.BestFriend9000.Desc", "Zawsze uważam ludzi za nieprzyjemnych. Wolę maszyny - one nie wbijają ci się w plecy! Nie doświadczyłeś szczęścia, dopóki nie podzielisz się piknikiem z drukarką i mikrofalówką.\n\nNie mam wyboru, muszę stworzyć własnego towarzysza robotycznego – przy pomocy ciebie, jeśli będziesz chciał.\n\nPierwszym przedmiotem, którego potrzebuję jest $ItemToGet" },
            { "Text.Quest.BestFriend9000.FirstObjective", "Zdobądź $ItemToGet" },
            { "Text.Quest.BestFriend9000.Name", "Robo-Przyjaciel 9000" },
            { "Text.Quest.BestFriend9000.Pt2.Desc", "Witaj znowu! Twoje podejście… wydaje się efektywne, co mnie cieszy. Przypomina mi to ekspres do kawy, z którym kiedyś byłem w towarzystwie.\n\nPotrzebuję kolejnego komponentu do mojego Robo-Przyjaciela, proszę o dostarczenie $ItemToGet."},
            { "Text.Quest.BestFriend9000.Pt3.Desc", "Serce?... Dusza?... bla. Moja maszyna zbliża się do zapewnienia mi nieskończonego chłodnego i pustego towarzystwa. Idealne.\n\nAby ukończyć mojego Robo-Przyjaciela potrzebuję źródła zasilania. Słyszałem, że $ItemSpawnLocation zawiera $ItemToGet."},
            { "Text.Quest.BestFriend9000.SecondObjective", "Zdobądź $ItemToGet od Strażnika w $ItemSpawnLocation" },
            { "Text.Quest.BestFriend9000.ThirdObjective", "Zdobądź $ItemToGet" },
            { "Text.Quest.Collect", "Zbierz $Ingr" },
            { "Text.Quest.Craft", "Wytwórz $ItemToCraft" },
            { "Text.Quest.DayAtTheSpa.FirstObjective", "Stwórz $ItemToCraft i oddaj go $DeliverTo" },
            { "Text.Quest.DayAtTheSpa.Name", "Dzień w SPA" },
            { "Text.Quest.Deliver", "Zanieś $ItemToCraft do $DeliverTo" },
            { "Text.Quest.DeliveryDriver.FirstObjective", "Zanieś $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.DeliveryDriver.Name", "Kierowca dostawowy" },
            { "Text.Quest.DeliveryDriver.SecondObjective", "Zanieś $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.Desk", "biurko" },
            { "Text.Quest.Discredit.Name", "Degradacja" },
            { "Text.Quest.Fallen Comrades.Desc", "Moja droga ucieczki jest już prawie gotowa — będę szczęśliwy, gdy wyjdę z tej nurkowej przygody!\\n\\nSzkoda, że zostawię tyle przyjaciół, którzy nie mogli pozwolić sobie na dołączenie. Byłoby super mieć coś, czym mogę ich wspominać, kiedy będę siedział na plaży po drugiej stronie świata…" },
            { "Text.Quest.Fallen Comrades.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.Fallen Comrades.Name", "Zaginieni Towarzysze" },
            { "Text.Quest.Fallen Comrades.Pt2.Desc", "Już spakowałem ostatnią błahostkę, którą mi dałeś, gotową na moją ucieczkę!\\n\\nSkoro tu jesteś, chciałbym zdobyć jeszcze kilka pamiątek dla przyjaciół.\\n\\nMógłbyś pomóc?" },
            { "Text.Quest.Fallen Comrades.SecondObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.Fallen Comrades.ThirdObjective", "Znajdź $ItemToGet1 dla $QuestGiver" },
            { "Text.Quest.FashionVictim.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.FashionVictim.Name", "Ofiara Mody" },
            { "Text.Quest.FollowerOfZergon.Desc", "Plotki są prawdziwe! Jestem wyznawcą Zegdethiana Schlippa!\\n\\nTylko wykonując schlippowski rytuał 'Gnarr Gnarr' mogę go przywołać, by mnie uwolnił!\\n\\nBędę potrzebował kilku rzeczy do tego procesu, pomożesz?" },
            { "Text.Quest.FollowerOfZergon.FirstObjective", "Zdobądź $ItemToGet x1, aby stworzyć schlippowski symbol" },
            { "Text.Quest.FollowerOfZergon.Name", "Wyznawca Zegdethiana Schlippa" },
            { "Text.Quest.FollowerOfZergon.Pt2.Desc", "Schlippowski symbol został stworzony!\\n\\nTeraz, Księga Schlippa mówi, że potrzebujemy $ItemToCraft do kolejnego kroku, mógłbyś go wykonać?" },
            { "Text.Quest.FollowerOfZergon.Pt3.Desc", "Chwała Zegdethianowi! Jesteśmy poruszeni twoimi promieniującymi mackami!\\n\\nTeraz potrzebujemy tylko $ItemToGet. Słyszałem, że $ItemSpawnLocation gromadzi różne kosmiczne dziwactwa, zacznij tam szukać." },
            { "Text.Quest.FollowerOfZergon.SecondObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.FollowerOfZergon.ThirdObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.IchLeibeKunst.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.IchLeibeKunst.Name", "Ich Liebe Kunst" },
            { "Text.Quest.InmatesForJustice.Desc", "Warunki się pogarszają! Czas, abyśmy my, ludzie, powstali!\\n\\nZacznijmy działać, pomóż mi pobić kilku strażników!" },
            { "Text.Quest.InmatesForJustice.FirstObjective", "Pobij $CombatTarget" },
            { "Text.Quest.InmatesForJustice.Name", "Powstanie" },
            { "Text.Quest.InmatesForJustice.Pt2.Desc", "Słyszałem, że dałeś popalić ostatniemu strażnikowi – dobra robota!\\n\\nAle to jeszcze nie koniec! A może kolejny?" },
            { "Text.Quest.InmatesForJustice.Pt3.Desc", "Ludzie mówią – powstanie wreszcie nabiera tempa.\\n\\nJeszcze jedno pobicie strażnika powinno wywołać rewolucję!" },
            { "Text.Quest.InmatesForJustice.SecondObjective", "Pobij $CombatTarget" },
            { "Text.Quest.InmatesForJustice.ThirdObjective", "Pobij $CombatTarget" },
            { "Text.Quest.LethalEnforcer.Desc", "Niektórzy bezczelni pracownicy potajemnie narzekają na naszego Chwalebnego Przywódcę!\\n\\nChciałbyś mieć zaszczyt ukarać tych zdrajców?" },
            { "Text.Quest.LethalEnforcer.FirstObjective", "Pobij $CombatTarget" },
            { "Text.Quest.LethalEnforcer.ForthObjective", "Pobij i związ $CombatTarget" },
            { "Text.Quest.LethalEnforcer.Name", "Śmiertelny Egzekutor" },
            { "Text.Quest.LethalEnforcer.Pt2.Desc", "Zlokalizowałem kolejnego plotkarza. Nie możemy tolerować, aby imię Chwalebnego Przywódcy było szargane.\\n\\nIdź i ucisz $CombatTarget!" },
            { "Text.Quest.LethalEnforcer.Pt3.Desc", "Napływają raporty, że $CombatTarget wyśmiewa się z wspaniałej fryzury Chwalebnego Przywódcy!\\n\\nPokaż mu, gdzie jego miejsce!" },
            { "Text.Quest.LethalEnforcer.Pt4.Desc", "Jestem oburzony! $CombatTarget odmówił pocałowania buta Chwalebnego Przywódcy!\\n\\nDaj mu przykład natychmiast!" },
            { "Text.Quest.LethalEnforcer.SecondObjective", "Pobij $CombatTarget" },
            { "Text.Quest.LethalEnforcer.ThirdObjective", "Pobij $CombatTarget" },
            { "Text.Quest.LocationLocationLocation.FirstObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.LocationLocationLocation.Name", "Lokalizacja Lokalizacja" },
            { "Text.Quest.Locksmith.FirstObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.Locksmith.Name", "Ślusarz" },
            { "Text.Quest.Locksmith.SecondObjective", "Wytwórz $ItemToCraft1" },
            { "Text.Quest.Locksmith.ThirdObjective", "Wytwórz $ItemToCraft2 dla $QuestGiver" },
            { "Text.Quest.LostProbe.Desc", "Ci agenci naprawdę są wytrwali, gdy mnie przesłuchują!\\n\\nChcę dowiedzieć się, co nimi kieruje, ale najpierw potrzebuję kilku rzeczy…" },
            { "Text.Quest.LostProbe.Name", "Zaginiona Sonda" },
            { "Text.Quest.LostProperty.FirstObjective", "Znajdź $ItemToGet należący do $QuestGiver" },
            { "Text.Quest.LostProperty.Name", "Zaginione Mienie" },
            { "Text.Quest.P45.FirstObjective", "Spraw, aby $JobTarget stracił pracę $Job" },
            { "Text.Quest.P45.Name", "P45" },
            { "Text.Quest.SeaSick.Desc", "Eugh… całe to morskie powietrze sprawia, że czuję się mdło.\\n\\nMógłbyś przynieść mi $ItemToGet z $ItemSpawnLocation? Szybko, zanim…" },
            { "Text.Quest.SeaSick.FirstObjective", "Przynieś $ItemToGet dla $QuestGiver" },
            { "Text.Quest.SeaSick.Name", "Chory na Morzu" },
            { "Text.Quest.SeaSick.SecondObjective", "Przynieś $ItemToGet dla $QuestGiver" },
            { "Text.Quest.SeaSick_Pt2.Desc", "To zdecydowanie pomogło na moją chorobę, ale zajęło ci to trochę za długo!\\n\\nBardzo przydałby mi się $ItemToGet, aby posprzątać bałagan, który zrobiłem…" },
            { "Text.Quest.ShipsInTheNight.Desc", "Nie jest tajemnicą, że od wielu tygodni mam słabość do $DeliverItemTo. Po prostu jestem zbyt nieśmiały, by to powiedzieć!\\n\\nMam w biurku list, który wszystko wyjaśnia, mógłbyś go dostarczyć?" },
            { "Text.Quest.ShipsInTheNight.FirstObjective", "Dostarcz $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.ShipsInTheNight.Name", "Spotkanie w Nocy" },
            { "Text.Quest.ShipsInTheNight.Pt2.Desc", "$DeliverTo wygląda na zdruzgotanego! Czy to mój list?\\n\\nMoże potrzebują ładnego prezentu, by poprawić sobie humor?" },
            { "Text.Quest.ShipsInTheNight.Pt3.Desc", "Niestety, $DeliverTo nie wydawał się zbyt pod wrażeniem ostatniego prezentu...\\n\\nPotrzebuję wysłać coś, co pokaże, jak mocno czuję." },
            { "Text.Quest.ShipsInTheNight.SecondObjective", "Wytwórz $ItemToCraft i dostarcz do $DeliverTo" },
            { "Text.Quest.ShipsInTheNight.ThirdObjective", "Wytwórz $ItemToCraft i dostarcz do $DeliverTo" },
            { "Text.Quest.SickNote.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.SportsFan.Desc", "Spróbuj zachować spokój, gdy ci to powiem, ale jestem o krok od skompletowania mojej kolekcji sportowych pamiątek!\\n\\nBrakuje mi tylko kilku rzadkich przedmiotów. Zastanawiałem się, czy mógłbyś mi pomóc?" },
            { "Text.Quest.SportsFan.FirstObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.SportsFan.Name", "Sportowa Kolekcja" },
            { "Text.Quest.SportsFan.Pt2.Desc", "Czy dobrze słyszę, że $ItemSpawnLocation ma rzadki $ItemToGet?\\n\\nPotrzebuję go!" },
            { "Text.Quest.SportsFan.Pt3.Desc", "Od naszej ostatniej rozmowy udało mi się znaleźć kilka kolejnych przedmiotów do mojej kolekcji sportowej. Teraz potrzebuję tylko tej brakującej części – $ItemToCraft.\\n\\nMoże mógłbyś ją dla mnie wykonać?" },
            { "Text.Quest.SportsFan.SecondObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.SportsFan.ThirdObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.StolenGoods.FirstObjective", "Odzyskaj $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.StolenGoods.Name", "Skradzione Towary" },
            { "Text.Quest.StolenTreasure.Desc", "Wiedziałem, że błahostki, które wyłowiłem z oceanu, wywołają zazdrość, ale spodziewałem się więcej po $ItemSpawnLocation!\\n\\nCzy mógłbyś odzyskać mój $ItemToGet?" },
            { "Text.Quest.StolenTreasure.FirstObjective", "Odzyskaj $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.StolenTreasure.Name", "Skradziony Skarb" },
            { "Text.Quest.StolenTreasure.Pt2.Desc", "W końcu znalazłem drugą błahostkę!\\n\\nMój skradziony $ItemToGet został sprzedany do $ItemSpawnLocation, ale odmawiają jego zwrotu! Proszę, interweniuj..." },
            { "Text.Quest.StolenTreasure.SecondObjective", "Odzyskaj $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.TheArmsDealer.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.TheArmsDealer.Name", "Apel o Broń" },
            { "Text.Quest.TheBeatdown.FirstObjective", "Pobij $CombatTarget" },
            { "Text.Quest.TheBeatdown.Name", "Pobicie" },
            { "Text.Quest.TheChef.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.TheChef.Name", "Kucharz" },
            { "Text.Quest.TheConductor.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.TheConductor.Name", "Dyrygent" },
            { "Text.Quest.TheConspiracyTheorist.Desc", "Obcy nadchodzą!\\n\\nByłem zbyt zajęty ostrzeganiem ludzi przez lata, że jestem całkowicie nieprzygotowany.\\n\\nZrób mi $ItemToCraft, aby uniemożliwić im czytanie moich myśli!" },
            { "Text.Quest.TheConspiracyTheorist.FirstObjective", "Wytwórz $ItemToCraft i daj $DeliverTo" },
            { "Text.Quest.TheConspiracyTheorist.Name", "Teoretyk Spiskowy" },
            { "Text.Quest.TheConspiracyTheorist.Pt2.Desc", "Mówiłem ci, że obcy nadchodzą, ale obawiam się, że już tu są, ukryci wśród nas!\\n\\nZauważyłeś, jak $DeliverItemTo wygląda jak jaszczurka? Bardzo podejrzane, jeśli mnie pytasz...\\n\\nPodstaw $ItemToGet do ich biurka, muszę się upewnić!" },
            { "Text.Quest.TheConspiracyTheorist.Pt3.Desc", "Gdybym mógł tylko skomunikować się z macierzystym statkiem obcych, mógłbym spróbować z nimi negocjować, potencjalnie ratując ludzkość przed wyginięciem!\\n\\nPrzynieś mi $ItemToCraft, a zobaczę, co da się zrobić." },
            { "Text.Quest.TheConspiracyTheorist.SecondObjective", "Znajdź $ItemToGet i włóż do biurka $DeliverItemTo" },
            { "Text.Quest.TheConspiracyTheorist.ThirdObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.TheDistraction.FirstObjective", "Stwórz rozproszenie podczas $RuckusType" },
            { "Text.Quest.TheDistraction.Name", "Rozproszenie" },
            { "Text.Quest.TheMule.FirstObjective", "Dostarcz $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.TheMule.Name", "Muł" },
            { "Text.Quest.ThePrisonSpecialist.Desc", "Ta niesamowita utopia pozwala nam żyć w prawdziwej pomyślności! Jesteśmy zazdrością całego świata!\\n\\nCzy nie powinniśmy znaleźć odpowiedniego daru wdzięczności dla naszego Chwalebnego Przywódcy, który to umożliwia?" },
            { "Text.Quest.ThePrisonSpecialist.FirstObjective", "Zdobądź $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.ThePrisonSpecialist.Name", "Stowarzyszenie Wdzięczności" },
            { "Text.Quest.ThePrisonSpecialist.Pt2.Desc", "To potwierdzone!\\n\\nChwalebny Przywódca właśnie samodzielnie schwytał wrogi samolot, a potem pokonał wielkiego niedźwiedzia górskiego – zgodnie z przepowiednią!\\n\\nŚpieszmy się, musimy zebrać kolejny dar wdzięczności!" },
            { "Text.Quest.ThePrisonSpecialist.Pt3.Desc", "Nie widziałeś wiadomości?\\n\\nNasz niesamowity program kosmiczny właśnie odkrył i przejął Księżyc, wszystko w imię Chwalebnego Przywódcy! Pionierujemy podróże kosmiczne!\\n\\nOn będzie oczekiwał natychmiastowego prezentu pochwalnego, uczynisz to ponownie?" },
            { "Text.Quest.ThePrisonSpecialist.SecondObjective", "Zdobądź $ItemToGet1 z $ItemSpawnLocation1" },
            { "Text.Quest.ThePrisonSpecialist.ThirdObjective", "Zdobądź $ItemToGet2 z $ItemSpawnLocation2" },
            { "Text.Quest.TheSuckUp.FirstObjective", "Wyczyść i zwróć $QuestGiver's $Uniform" },
            { "Text.Quest.TheSuckUp.Name", "Sprzątacz" },
            { "Text.Quest.TheWetBandit.FirstObjective", "Zalej toaletę $FloodTarget" },
            { "Text.Quest.TheWetBandit.Name", "Mokra Banda" },
            { "Text.Quest.UpForParole.Desc", "Ekscytujące czasy!\\n\\nMam spotkanie w sprawie warunkowego zwolnienia w przyszłym tygodniu, muszę dobrze wyglądać, by zrobić wrażenie na komisji.\\n\\nZnajdź mi $ItemToGet, a dam ci kilka monet." },
            { "Text.Quest.UpForParole.FirstObjective", "Znajdź $ItemToGet dla $QuestGiver" },
            { "Text.Quest.UpForParole.Name", "Oczekujące Zwolnienie Warunkowe" },
            { "Text.Quest.UpForParole.Pt2.Desc", "Dobrze się spisałeś, ale będę potrzebował więcej, by zaimponować bezlitosnej komisji!\\n\\nCzy mógłbyś wykonać dla mnie $ItemToCraft?" },
            { "Text.Quest.UpForParole.Pt3.Desc", "Ojej! Podobno mam konkurencję – $DeliverItemTo również oczekuje na zwolnienie warunkowe! Może włóż ten $ItemToGet do ich biurka, aby strażnicy go znaleźli… Jestem pewien, że mój wzorowy rekord przeważy na komisji!" },
            { "Text.Quest.UpForParole.SecondObjective", "Wytwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.UpForParole.ThirdObjective", "Włóż $ItemToGet do biurka $DeliverItemTo" },
            { "Text.Quest.WantedDeadOrAlive.Desc", "Kilku drańków tutaj mnie skrzywdziło i trzeba ich upokorzyć.\\n\\nMasz ochotę ich zebrać dla mnie?" },
            { "Text.Quest.WantedDeadOrAlive.FirstObjective", "Pobij i związ $CombatTarget" },
            { "Text.Quest.WantedDeadOrAlive.Name", "Związany" },
            { "Text.Quest.WantedDeadOrAlive.Pt2.Desc", "Yehaw! Jeden załatwiony!\\n\\nChcę, abyś następnego też porządnie związał…" },
            { "Text.Quest.WantedDeadOrAlive.Pt3.Desc", "Pokazałeś im!\\n\\nTeraz trudniej – następny cel to strażnik. Mogę na ciebie liczyć?" },
            { "Text.Quest.WantedDeadOrAlive.SecondObjective", "Pobij i związ $CombatTarget" },
            { "Text.Quest.WantedDeadOrAlive.ThirdObjective", "Pobij i związ $CombatTarget" },
            { "Text.Quest.WasteManagement.FirstObjective", "Zniszcz $QuestGiver's $ItemToDestroy" },
            { "Text.Quest.WasteManagement.Name", "Gospodarka Odpadami" },
            { "Text.Quest.WorldsWorstBirthday.Desc", "Moje urodziny nadchodzą, a myślę, że moi przyjaciele znowu zapomnieli je zaplanować! Głupcy!\\n\\nBędę musiał zorganizować je sam. Czy mógłbyś pomóc w kilku sprawunkach?" },
            { "Text.Quest.WorldsWorstBirthday.FifthObjective", "Spłucz $ItemToDestroy w toalecie" },
            { "Text.Quest.WorldsWorstBirthday.FirstObjective", "Dostarcz $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.WorldsWorstBirthday.ForthObjective", "Wytwórz $ItemToCraft" },
            { "Text.Quest.WorldsWorstBirthday.Name", "Najgorsze Urodziny Świata" },
            { "Text.Quest.WorldsWorstBirthday.Pt2.Desc", "Dzięki za ogarnięcie tych urodzinowych planów, powinien to być dobry dzień!\\n\\nTeraz potrzebuję tylko tortu, bo nikt nie pomyślał, żeby kupić."},
            { "Text.Quest.WorldsWorstBirthday.Pt3.Desc", "Klapa… Nikt nie przyjdzie na moją imprezę, brak kartek – nic!\\n\\nDzięki za przygotowanie tortu, ale nagle straciłem apetyt. Pozbądź się go…"},
            { "Text.Quest.WorldsWorstBirthday.SecondObjective", "Dostarcz $ItemToGet1 do $DeliverItemTo1" },
            { "Text.Quest.WorldsWorstBirthday.ThirdObjective", "Dostarcz $ItemToGet2 do $DeliverItemTo2" },
            { "Text.Quest.Vampire.Name", "Co robi w cieniu…" },
            { "Text.Quest.Vampire.Desc", "Pewnie wiesz, że na strychu mieszka wampir. Zawsze budzę się z ugryzieniami od tego krwiopijcy. \\n\\n Potrzebuję, żebyś zdobył dla mnie wody po goleniu, mam nadzieję, że odstraszy to jego podniebienie następnym razem, gdy zbliży się do mojego karku!" },
            { "Text.Quest.Vampire.FirstObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.Vampire.Pt2.Desc", "Eurrghh… Przepraszam, ta ohydna istota znów zaatakowała mój kark. \\n\\n Potrzebuję, żebyś stworzył dla mnie manekina do łóżka, chcę oszukać tego potwora, żeby się pojawił, a wtedy go wyeliminuję, kiedy się najmniej spodziewa!" },
            { "Text.Quest.Vampire.SecondObjective", "Stwórz $ItemToCraft i przekaż $DeliverTo" },
            { "Text.Quest.Vampire.Pt3.Desc", "Ten przeklęty stwór znów mnie ugryzł… \\n\\n Teraz potrzebuję tylko drewnianego kołka, wtedy będę gotów zastawić pułapkę i zakończyć to raz na zawsze! \\n\\n Słyszałem, że strażnicy przechowują drewniany kołek w piwnicy tego miejsca." },
            { "Text.Quest.Vampire.ThirdObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.BumpInTheNight.Name", "Hałas w Nocy" },
            { "Text.Quest.BumpInTheNight.Desc", "Jestem pewien, że mogę przekonać innych tutaj, że w więzieniu jest duch! Najpierw muszę wymyślić postać dla mojego 'ducha', pewnie znajdzie się gdzieś stare zdjęcie rodzinne, którego mogę użyć?" },
            { "Text.Quest.BumpInTheNight.FirstObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.BumpInTheNight.Pt2.Desc", "Naprawdę przestraszy innych, jeśli duch zacznie z nimi rozmawiać, prawda? Zdobyj dla mnie puszkę farby, nasz duch zacznie zostawiać wiadomości na ścianach!" },
            { "Text.Quest.BumpInTheNight.SecondObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.BumpInTheNight.Pt3.Desc", "Nie mogę uwierzyć, jak dobrze to działa! Teraz ostatni krok… wszyscy nienawidzą strasznych lalek, prawda? Jeśli stworzysz figurkę Escapists i umieścisz ją w biurku, naprawdę przestraszy wszystkich!" },
            { "Text.Quest.BumpInTheNight.ThirdObjective", "Stwórz $ItemToCraft i umieść w biurku $DeliverItemTo" },
            { "Text.Quest.DeeperUnderground.Name", "Mój Zombie" },
            { "Text.Quest.DeeperUnderground.Desc", "Dlaczego wszyscy źle traktują zombie? Kilku dręczycieli ukradło rękę Zombie i ją ukryli! Proszę, odzyskaj ją…" },
            { "Text.Quest.DeeperUnderground.FirstObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.DeeperUnderground.Pt2.Desc", "Jestem pewien, że w tych zombie można dostrzec trochę człowieczeństwa… Stwórz dla mnie sztuczny kwiat, chcę sprawdzić, czy wzbudzi wspomnienia."},
            { "Text.Quest.DeeperUnderground.SecondObjective", "Stwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.DeeperUnderground.Pt3.Desc", "Może to dlatego, że poruszają się tak wolno, że są prześladowane? Hmmm… może napój energetyczny doda im wigoru?" },
            { "Text.Quest.DeeperUnderground.ThirdObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.DeeperUnderground.Pt4.Desc", "Zombie są łatwymi celami, ale jeśli stworzysz dla mnie wyściełany strój więźnia, możemy ochronić przynajmniej jednego z nich. Oh… i jeśli będziesz mi pomagać dalej, mogę podzielić się informacjami, jak uciec z tego miejsca."},
            { "Text.Quest.DeeperUnderground.FourthObjective", "Stwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.DeeperUnderground.Pt5.Desc", "Ludzie w końcu zaczynają traktować zombie z szacunkiem. No… prawie wszyscy. Zrób mi przysługę – stwórz siekierę, a następnie użyj jej na $CombatTarget. Nauczą się w ten sposób."},
            { "Text.Quest.DeeperUnderground.FifthObjective", "Pobij $CombatTarget używając $ItemToCraft" },
            { "Text.Quest.DeeperUnderground.Pt6.Desc", "Czy wiesz, że tutaj jest krypta? Pod cmentarzem… Podobno ma sekretne przejście. Jeden z zombie twierdzi, że klucz może je otworzyć. Tak czy inaczej, zgubiłem książkę o okultyzmie. Możesz ją znaleźć?"},
            { "Text.Quest.DeeperUnderground.SixthObjective", "Zdobyć $ItemToGet z $ItemSpawnLocation" },
            { "Text.Quest.DeeperUnderground.Pt7.Desc", "Pamiętasz sekretne przejście, o którym wspomniałem? Mogę mieć klucz… Ale o tym później. Możesz stworzyć dla mnie cienką łopatę? Chcę uwolnić więcej nieumarłych z cmentarza…"},
            { "Text.Quest.DeeperUnderground.SevenObjective", "Stwórz $ItemToCraft i przekaż $DeliverTo" },
            { "Text.Quest.DeeperUnderground.Pt8.Desc", "Jeśli stworzysz dla mnie super kastet, mogę chronić zombie na zawsze. Zrób to, a dam Ci klucz do sekretnego przejścia… Potem wejdź do trumny na północnym zachodzie i uciekaj przez kryptę!"},
            { "Text.Quest.DeeperUnderground.EightObjective", "Stwórz $ItemToCraft i przekaż $DeliverTo" },
            { "Text.Quest.BakeOff.Name", "Piekarnicze zawody" },
            { "Text.Quest.BakeOff.Desc", "Będziemy mieli konkurs pieczenia Mince Pie! Ale ekscytujące! Nie mam wszystkich potrzebnych składników, bądź gwiazdą i przynieś mi trochę mąki, dobrze?" },
            { "Text.Quest.BakeOff.FirstObjective", "Weź $ItemToGet i przynieś do $QuestGiver" },
            { "Text.Quest.BakeOff.Pt2.Desc", "Och, dziękuję! To przyjazny konkurs, ale byłoby mi bardzo pomocne, gdyby ta martwa szczur… jakoś… trafiła do biurka $DeliverItemTo. Rozumiesz, kochanie?" },
            { "Text.Quest.BakeOff.SecondObjective", "Umieść $ItemToGet w biurku $DeliverItemTo." },
            { "Text.Quest.BakeOff.Pt3.Desc", "No cóż, jesteś cudownym pomocnikiem! Teraz ktoś wlał kwas do mojego ciasta, więc biedna ja nie mam placka do pokazania! Czy możesz zrobić mi jeden?" },
            { "Text.Quest.BakeOff.ThirdObjective", "Upiecz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.SecretSanta.Name", "Tajny Mikołaj" },
            { "Text.Quest.SecretSanta.Desc", "KOCHAM ten czas roku! Uwielbiam dawać prezenty… Tutaj, włóż to do biurka $DeliverItemTo." },
            { "Text.Quest.SecretSanta.FirstObjective", "Umieść $ItemToGet w biurku $DeliverItemTo." },
            { "Text.Quest.SecretSanta.Pt2.Desc", "Jestem takim człowiekiem, po prostu DAJĘ, DAJĘ, DAJĘ. Nie wierzysz mi?! Wykonaj $ItemToCraft i daj go $DeliverTo." },
            { "Text.Quest.SecretSanta.SecondObjective", "Wykonaj $ItemToCraft i daj $DeliverTo" },
            { "Text.Quest.SecretSanta.Pt3.Desc", "Smutno mi, gdy ludzie nie doceniają mojej HOJNOŚCI. Wykonaj $ItemToCraft i naucz $CombatTarget, dlaczego POWINNI DOCENIĆ tę koszulkę ‘PRZYJACIELE NA ZAWSZE’, którą dla nich zrobiłem!" },
            { "Text.Quest.SecretSanta.ThirdObjective", "Pobij $CombatTarget przy użyciu $ItemToCraft" },
            { "Text.Quest.NoLaughingMatter.Name", "Nie Ma Siary" },
            { "Text.Quest.NoLaughingMatter.Desc", "Publiczność uwielbia mój klaunowy samochód, ale… uwaga… został odholowany! Okazało się, że strażnik parkingowy zauważył fałszywy bilet parkingowy, który napisałem. Na szczęście $DeliverItemTo zgodził się pomóc. Weź list, który otrzymałem…" },
            { "Text.Quest.NoLaughingMatter.FirstObjective", "Dostarcz $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.NoLaughingMatter.Pt2.Desc", "Mój prawnik mówi, że nikt nie weźmie mnie na serio, gdy poproszę o zwrot samochodu… Powinienem wyglądać schludnie, zrobić wrażenie… możesz zdobyć dla mnie $ItemToGet z kwater strażników?" },
            { "Text.Quest.NoLaughingMatter.SecondObjective", "Zdobyć $ItemToGet i zwrócić do $QuestGiver" },
            { "Text.Quest.NoLaughingMatter.Pt3.Desc", "Zgadnij co, nadal nie mam klaunowego samochodu! Co za żart… Ale mam przebiegły plan. Dowiedziałem się, gdzie jest przechowywany… Jeśli stworzysz dla mnie Chwiejne Nożyczki, mogę go odzyskać po zgaszeniu światła!" },
            { "Text.Quest.NoLaughingMatter.ThirdObjective", "Stwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.SmokeAndMirrors.Name", "Dym i Lustra" },
            { "Text.Quest.SmokeAndMirrors.Desc", "Mój Asystent uciekł z jednym z Gimnastów… Mogę być jasnowidzem, ale tego się nie spodziewałem… Musisz zdobyć manekina, którego używałem jako dublera do jednego z moich trików i się go pozbyć… już go nie potrzebuję…" },
            { "Text.Quest.SmokeAndMirrors.FirstObjective", "Odzyskaj i zniszcz $ItemToDestroy1 należący do $QuestGiver" },
            { "Text.Quest.SmokeAndMirrors.Pt2.Desc", "Wymyśliłem koncepcję mojego najnowszego iluzjonistycznego triku! Odważny wyczyn, który kwestionuje wyobrażenia publiczności o tym, co jest możliwe! Zniknę przez ścianę, całkowicie bez przeszkód. Proszę, stwórz dla mnie Fałszywy Blok Ściany, żebym mógł zacząć ćwiczyć." },
            { "Text.Quest.SmokeAndMirrors.SecondObjective", "Stwórz $ItemToCraft i przekaż do $DeliverTo" },
            { "Text.Quest.SmokeAndMirrors.Pt3.Desc", "Otrzymałem polecenie od $CombatTarget, aby 'mieszać się w tłum'… powinienem być na scenie, a nie pokazywać sztuczki karciane na parkingu! Niestety… moje wynagrodzenie jest zamrożone, dopóki się temu nie podporządkuję. Dlaczego więc nie stworzysz Kija Baseballowego i nie pokażesz $CombatTarget sztuczki 'Magicznie pojawiające się siniaki'?" },
            { "Text.Quest.SmokeAndMirrors.ThirdObjective", "Pobij $CombatTarget za pomocą $ItemToCraft" },
            { "Text.Quest.EternallyGrateful.Name", "Wiecznie Wdzięczny" },
            { "Text.Quest.EternallyGrateful.Desc", "Psssst! Potrzebuję pomocy, ale zachowaj to w tajemnicy. Odkryłem, że rycerz, który tu mieszkał setki lat temu, znalazł sekret wiecznej młodości! Prowadził dziennik, który zniknął z biblioteki jakiś czas temu… czy możesz go znaleźć? Droga do nieśmiertelności musi być w tej książce." },
            { "Text.Quest.EternallyGrateful.FirstObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.EternallyGrateful.Pt2.Desc", "Interesujące… ah… tak. Widzę. Jest kamienna tablica, którą rycerz zdobył, i która musi zawierać klucz do wiecznej młodości. Artefakt takiej wagi musi być w gabinecie Nadzorcy. Proszę, zdobądź go dla mnie." },
            { "Text.Quest.EternallyGrateful.SecondObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.EternallyGrateful.Pt3.Desc", "Racja… ah, ok… bardzo interesujące… Wnioskuję, że tablica jest napisana starym językiem, którego nie rozumiem. Ale to nic, bo obawiam się, że nie jesteśmy sami w naszej misji! Widziałem wcześniej kogoś pijącego coś nietypowego, *to* musi być sekret wiecznej młodości. Natychmiast to zdobądź!" },
            { "Text.Quest.EternallyGrateful.ThirdObjectiveOLD", "Pokonaj $CombatTarget i zdobądź Naczynie Wiecznej Młodości, bogactwa, urody itp." },
            { "Text.Quest.ItBelongsInAMuseum.Name", "To Powinno Być W Muzeum!" },
            { "Text.Quest.ItBelongsInAMuseum.Desc", "To miejsce jest pełne historii, naprawdę niesamowite! Ale wiesz co mnie irytuje? Całkowity brak szacunku dla budynku i jego eksponatów. Napisałem list z zaleceniami dotyczącymi opieki nad budynkiem. Dostarcz go do członka personelu, aby przekazał Nadzorcy." },
            { "Text.Quest.ItBelongsInAMuseum.FirstObjective", "Dostarcz $ItemToGet do $DeliverItemTo" },
            { "Text.Quest.ItBelongsInAMuseum.Pt2.Desc", "Jak wielu moich rówieśników, używałem szczoteczki do delikatnego czyszczenia artefaktów tutaj. Zwróć uwagę na słowo ‘Używałem’… czas przeszły. Osoba, którą z żalem uważałem za zainteresowaną moją pracą, zabrała tę szczoteczkę i przerobiła na ostrze. Proszę, odzyskaj… 'ostrze' i zniszcz je, nie mogę już dłużej o tym myśleć." },
            { "Text.Quest.ItBelongsInAMuseum.SecondObjective", "Odzyskaj i zniszcz $ItemToDestroy1" },
            { "Text.Quest.ItBelongsInAMuseum.Pt3.Desc", "$CombatTarget używał autentycznego noża do… obcinania paznokci u stóp. Odrażające. W starych czasach takie zachowanie byłoby nie do przyjęcia… Stwórz $ItemToCraft i porządnie go uderz! Pokaż, jak powinno się używać tego sprzętu!" },
            { "Text.Quest.ItBelongsInAMuseum.ThirdObjective", "Uderz $CombatTarget używając $ItemToCraft" },
            { "Text.Quest.EternallyGrateful.ThirdObjective", "Zdobądź Naczynie Wiecznej Młodości, bogactwa i urody itp. " },
            { "Text.Quest.Unionised.Name", "Związki Zawodowe" },
            { "Text.Quest.Unionised.Desc", "Warunki pracy są okropne… Wcześniej dostałem lanie za prośbę o przerwę na toaletę! Możesz zdobyć dla mnie Apteczkę? Strasznie boli mnie głowa…" },
            { "Text.Quest.Unionised.FirstObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.Unionised.Pt2.Desc", "Wysłaliśmy listy skarżące się na warunki pracy, ale one znikają. Słyszałem, że strażnicy po prostu trzymają je w pudełku oznaczonym 'Dlaczego potrzebujemy więcej Robotów'. Odzyskaj to pudełko dla mnie…" },
            { "Text.Quest.Unionised.SecondObjective", "Zdobyć $ItemToGet i wrócić do $QuestGiver" },
            { "Text.Quest.Unionised.Pt3.Desc", "Sprawy posunęły się za daleko, musimy wysłać wiadomość! Czas na strajk! I mam zamiar uderzyć strażnika najstraszniejszą z broni w naszym elfim arsenale… Cukrowym Bólem!" },
            { "Text.Quest.Unionised.ThirdObjective", "Uderz $CombatTarget Cukrowym Bólem" },
            { "Text.Quest.ChristmasPast.Name", "Duch Przeszłych Świąt" },
            { "Text.Quest.ChristmasPast.Desc", "Musimy przypomnieć Mikołajowi, jak było wcześniej, zanim wszystko zostało zautomatyzowane… Powinien gdzieś tu być Malowany Drewniany Żołnierz, włóż go do jego biurka…" },
            { "Text.Quest.ChristmasPast.FirstObjective", "Umieść $ItemToGet w biurku Mikołaja" },
            { "Text.Quest.ChristmasPast.Pt2.Desc", "Jego nastrój się nie poprawił… nie był taki sam od zeszłych Świąt. Zastanawiam się, czy Ciastko z Mincem by go pocieszyło? Stworzysz je, ja mu je dam!" },
            { "Text.Quest.ChristmasPast.SecondObjective", "Stwórz $ItemToCraft dla $QuestGiver" },
            { "Text.Quest.ChristmasPast.Pt3.Desc", "To ciastko wywołało u niego wspomnienia o pobiciu i kradzieży stroju! Powinniśmy wysłać mu zdjęcie nas wszystkich sprzed powstania imperium online… Problem w tym, że zdjęcia zostały skonfiskowane przez strażników…" },
            { "Text.Quest.ChristmasPast.ThirdObjective", "Umieść $ItemToGet w biurku Mikołaja" }
        };

        public static readonly Dictionary<string, List<string>> Variants = new Dictionary<string, List<string>>
        {
            { "Text.Quest.DeliveryDriver", new List<string> {
            "Muszę się z kimś dogadać – możesz dostarczyć ten pakunek?",
            "Potrzebuję, żebyś przekazał to pewnemu więźniowi. Nie pytaj, co w środku.",
            "Mam przesyłkę do przekazania. Zrobisz to za mnie?",
            "Nie mogę się z tym pokazać, zanieś to za mnie, dobra?"
            } },

            { "Text.Quest.ArtsAndCrafts", new List<string> {
            "Zrób mi coś specjalnego, użyj tych materiałów.",
            "Masz zdolne ręce? Potrzebuję, żebyś coś mi stworzył.",
            "Zmajstruj coś z tego – ja nie mam cierpliwości.",
            "Potrzebuję konkretnego przedmiotu, dasz radę go zrobić?"
            } },

            { "Text.Quest.BeatTheBully", new List<string> {
            "Ktoś tu się za bardzo panoszy – daj mu nauczkę.",
            "Mam dosyć tego typa, spuść mu manto.",
            "Ten gość mnie gnębi, możesz go obić?",
            "Przydałoby się, żeby ktoś go wreszcie uciszył."
            } },

            { "Text.Quest.Destroyer", new List<string> {
            "Chcę, żebyś zniszczył pewien przedmiot. Wiesz który.",
            "Załatw, żeby ten przedmiot zniknął z powierzchni ziemi.",
            "Zniszcz to coś, zanim trafi w niepowołane ręce.",
            "Rozwal to – im szybciej, tym lepiej."
            } },

            { "Text.Quest.DistractionAtRollCall", new List<string> {
            "Potrzebuję odwrócić uwagę na apelu – zrobisz dla mnie mały chaos?",
            "Zrób zamieszanie podczas apelu, żebym mógł coś załatwić.",
            "Podczas apelu zrób trochę hałasu – zajmij uwagę strażników.",
            "Muszę coś przemycić – odwróć uwagę strażników w czasie apelu."
            } },

            { "Text.Quest.DistractionAtShowerTime", new List<string> {
            "Zrób zamieszanie w czasie prysznica – muszę coś wynieść.",
            "Rozróba pod prysznicem? Brzmi jak plan!",
            "Zajmij strażników w łaźni, dobra?",
            "Potrzebuję cię do odwrócenia uwagi w czasie kąpieli."
            } },

            { "Text.Quest.DistractionAtExerciseTime", new List<string> {
            "Podczas treningu odwróć uwagę strażników, dobra?",
            "Muszę coś wynieść z siłowni – zrób mały cyrk, żeby nikt nie zauważył.",
            "Zrób zadyme na siłowni!",
            "Odwróć uwagę w czasie ćwiczeń – to dla mojego dobra."
            } },

            { "Text.Quest.DistractionAtMealTime", new List<string> {
            "Zrób zamieszanie w stołówce – strażnicy muszą się odwrócić.",
            "Potrzebuję cię, żebyś rozproszył uwagę w czasie posiłku.",
            "Zrób hałas przy jedzeniu – niech się strażnicy pogubią.",
            "W czasie obiadu odwróć uwagę – ja się zajmę resztą."
            } },

            { "Text.Quest.DistractionAtWorkPeriod", new List<string> {
            "Podczas pracy odwróć uwagę strażników, muszę coś załatwić.",
            "Zrób zamieszanie w czasie zmiany roboczej.",
            "Muszę coś przemycić w pracy – potrzebna rozróba.",
            "Zajmij strażników, kiedy wszyscy pracują."
            } },

            { "Text.Quest.DistractionAtFreePeriod", new List<string> {
            "Podczas wolnego zrób zamieszanie, dobra?",
            "Muszę coś przenieść, potrzebuję cię, żebyś odwrócił uwagę.",
            "Zrób małą zadyme w czasie wolnym – nie pytaj czemu.",
            "Odwróć uwagę strażników w czasie wolnego, żebym mógł działać."
            } },

            { "Text.Quest.Favour", new List<string> {
            "Potrzebuję przysługi…",
            "Mam dla ciebie małe zlecenie.",
            "Chcesz zarobić trochę grosza?",
            "Zrobisz coś dla mnie?"
            } },

            { "Text.Quest.FetchQuest", new List<string> {
            "Znajdź to dla mnie – wiem, że gdzieś tu jest.",
            "Szukam pewnej rzeczy – pomożesz mi ją zdobyć?",
            "Potrzebuję konkretnego przedmiotu, znajdziesz go dla mnie?",
            "Zorganizuj mi to, a się odwdzięczę."
            } },

            { "Text.Quest.GiftOfFriendship", new List<string> {
            "Chcę się z kimś zaprzyjaźnić – przekaż mu to ode mnie.",
            "Zanieś to pewnemu więźniowi – niech wie, że nie jestem wrogiem.",
            "Pomóż mi poprawić relacje – przekaż mu ten prezent.",
            "Chcę dobrze wypaść przed kimś – dostarcz mu to."
            } },

            { "Text.Quest.LostProperty", new List<string> {
            "Zgubiłem coś cennego – pomożesz mi to znaleźć?",
            "Ktoś mi buchnął przedmiot – odzyskaj go, dobra?",
            "Zaginęła moja rzecz, przydałby się ktoś, kto ją odnajdzie.",
            "Znajdź i oddaj mi moją zgubę, zapłacę."
            } },

            { "Text.Quest.Mischief", new List<string> {
            "Zrób trochę bałaganu, chcę zobaczyć chaos!",
            "Muszę odwrócić uwagę strażników – zrób coś głupiego.",
            "Zrób zamieszanie, by nikt nie zwrócił uwagi na mnie.",
            "Zrób coś psotnego, żeby wszyscy się odwrócili."
            } },

            { "Text.Quest.Mugging", new List<string> {
            "Ten gość ma coś, co powinno należeć do mnie – zabierz mu to.",
            "Zrzuć go i przynieś mi, co ma przy sobie.",
            "Potrzebuję pewnej rzeczy, którą nosi inny więzień.",
            "Załatw typa i przynieś mi jego sprzęt."
            } },

            { "Text.Quest.PaidBeatdown", new List<string> {
            "Zapłacę ci, żebyś kogoś pobił.",
            "Ten gość działa mi na nerwy – zrób z tym coś.",
            "Chcę, żebyś dał nauczkę pewnemu typowi.",
            "Załatw go za mnie – dostaniesz zapłatę."
            } },

            { "Text.Quest.Theft", new List<string> {
            "Ktoś ma coś, co mi się należy – weź to i przynieś mi.",
            "Skradnij ten przedmiot dla mnie.",
            "Potrzebuję, żebyś zdobył coś od innego więźnia.",
            "Zrób to po cichu – nikt nie może wiedzieć."
            } },

            { "Text.Quest.TradingPlaces", new List<string> {
            "Zamień ten przedmiot z kimś innym – obaj na tym skorzystamy.",
            "Zrób wymianę – ja ci dam to, a ty zdobądź tamto.",
            "Potrzebuję, żebyś dokonał małej transakcji.",
            "Zrób wymianę, tylko cicho, dobra?"
            } },

            { "Text.Quest.TutorialIntro", new List<string> {
            "Zacznijmy od podstaw – nauczę cię, jak tu przetrwać.",
            "Słuchaj uważnie – pokażę ci, jak się tu robi interesy.",
            "Na początek mała lekcja życia w więzieniu.",
            "Zrobisz, co mówię, a może nawet przeżyjesz."
            } },

            { "Text.Quest.TutorialCrafting", new List<string> {
            "Teraz nauczysz się tworzyć przedmioty – to podstawa.",
            "Spróbuj coś zmajstrować, przyda ci się to później.",
            "Zrób własnoręcznie coś prostego – nauczysz się rzemiosła.",
            "Tworzenie to sztuka przetrwania – zobacz, jak to się robi."
            } },

            { "Text.Quest.TutorialCombat", new List<string> {
            "Zobaczmy, czy potrafisz się bić.",
            "Pora sprawdzić twoje umiejętności w walce.",
            "Bij, zanim ciebie pobiją – czas na trening!",
            "Nie ma ucieczki bez siły – pokaż, co potrafisz."
            } },

            { "Text.Quest.TutorialEscape", new List<string> {
            "Najważniejsze — dowiedz się, jak uciec stąd żywym.",
            "Pokażę ci, jak planować ucieczkę. Patrz i ucz się.",
            "To jest więzienie, więc... czas się nauczyć, jak z niego zwiać.",
            "Zobacz, jak to się robi — ucieczka krok po kroku."
            } },

            { "Text.Quest.TutorialJob", new List<string> {
            "Musisz znaleźć sobie pracę, żeby nie zdechnąć z głodu.",
            "Zobacz, jak działa system pracy w więzieniu.",
            "Zarób pierwsze pieniądze — znajdź robotę.",
            "Każdy coś robi. Ty też będziesz — czas na pierwszą fuchę."
            } },

            { "Text.Quest.TutorialRollCall", new List<string> {
            "Zawsze melduj się na apelu — strażnicy mają oko na każdego.",
            "Pokażę ci, jak wygląda apel — to codzienna rutyna.",
            "Nie olewaj apelu, inaczej podniesie się poziom ochrony.",
            "Apel to obowiązek — idziemy!"
            } },

            { "Text.Quest.TutorialStats", new List<string> {
            "Siła, kondycja i inteligencja — to podstawa przetrwania.",
            "Pora trochę się rozruszać i pomądrzyć.",
            "Podciągnij swoje statystyki, żeby nie być mięczakiem.",
            "Bez treningu i nauki nie uciekniesz stąd nigdy."
            } },

            { "Text.Quest.TutorialStore", new List<string> {
            "Masz kasę? Pokażę ci, gdzie kupować rzeczy.",
            "Handel to klucz — wszystko da się tu załatwić.",
            "Pokażę ci handlarza — zawsze ma coś ciekawego.",
            "Tu nauczysz się, jak wydawać pieniądze z głową."
            } },

            { "Text.Quest.TutorialSummary", new List<string> {
            "I to tyle — teraz wiesz, jak przeżyć w tym miejscu.",
            "Świetnie ci poszło! Jesteś gotów na prawdziwą grę.",
            "To koniec szkolenia — teraz działasz sam.",
            "Znasz już zasady. Reszta zależy od ciebie."
            } },

            { "Text.Quest.TutorialTools", new List<string> {
            "Zróbmy sobie kilka narzędzi — przydadzą się w ucieczce.",
            "Nie uciekniesz z gołymi rękami — czas zrobić coś użytecznego.",
            "Zróbmy łopatę, pilnik albo coś, co pomoże ci zwiać.",
            "Narzędzia to podstawa. Bez nich nigdzie nie dojdziesz."
            } },

            { "Text.Quest.TutorialWeapons", new List<string> {
            "Pokażę ci, jak się uzbroić — niektórzy tu nie żartują.",
            "Bez broni długo tu nie pożyjesz. Czas coś zrobić.",
            "Zrób prostą broń — kij, ostrze, cokolwiek.",
            "Siła to jedno, ale broń robi różnicę."
            } },

            { "Text.Quest.TutorialWorkout", new List<string> {
            "Czas na trening! Wzmocnij mięśnie, bo będą potrzebne.",
            "Do siłowni marsz — pokaż, że masz moc.",
            "Podciągnij się parę razy — przyda się później.",
            "Im silniejszy jesteś, tym łatwiej ci pójdzie."
            } },

            { "Text.Quest.Witness", new List<string> {
            "Ktoś widział coś, czego nie powinien — zajmij się tym.",
            "Potrzebuję, żebyś uciszył świadka.",
            "Ten gość za dużo wie. Zrób, żeby zapomniał.",
            "Nie chcę, żeby ten typ otworzył gębę – zrób z tym porządek."
            } },

            { "Text.Quest.WorkplaceRevenge", new List<string> {
            "Ktoś podłożył mi świnię w pracy — naucz go rozumu.",
            "Zabierz się za typa, który mnie wrobił w robocie.",
            "Zniszcz jego reputację, niech żałuje.",
            "Zrób z nim porządek – niech się nauczy nie zadzierać."
            } },

            { "Text.Quest.WorkplaceSabotage", new List<string> {
            "Sabotuj jego stanowisko pracy – niech straci robotę.",
            "Zrób tak, żeby nie mógł skończyć zmiany.",
            "Zniszcz coś w jego miejscu pracy – niech wyleci.",
            "Sabotaż czasem bywa skuteczniejszy niż pięści."
            } },

            { "Text.Quest.WorkplaceTheft", new List<string> {
            "Skradnij coś z jego stanowiska pracy.",
            "Zrób mu czystkę w szafce – niech się zdziwi.",
            "Potrzebuję, żebyś wyniósł coś z jego miejsca pracy.",
            "Zabierz mu to, zanim sam tego użyje."
            } },

            { "Text.Quest.WorkplaceTrade", new List<string> {
            "Zrób wymianę w czasie pracy – niech strażnicy nie zauważą.",
            "Wymień te rzeczy po cichu, w godzinach pracy.",
            "Zrób transakcję w robocie – tylko bez świadków.",
            "Załatw to w pracy, ale ostrożnie."
            } },

            { "Text.Quest.WorkplaceDelivery", new List<string> {
            "Zanieś to komuś w czasie pracy.",
            "Potrzebuję, żebyś dostarczył ten pakunek podczas zmiany.",
            "Zrób dostawę w robocie – ważne, żeby nikt nie zauważył.",
            "Podczas pracy przekaż to dalej – masz dyskrecję?"
            } },

            { "Text.Quest.WorkplaceFavor", new List<string> {
            "Zrób dla mnie przysługę w czasie pracy.",
            "Muszę coś załatwić w robocie – pomożesz?",
            "Zrób małą robotę podczas zmiany, zapłacę.",
            "Zrób to w pracy – przysłużysz mi się."
            } },

            { "Text.Quest.WorkplaceMischief", new List<string> {
            "Zrób zamieszanie w czasie pracy, potrzebuję chaosu.",
            "Zrób cyrk w robocie, odwróć uwagę strażników.",
            "Trochę rozróby w pracy? Brzmi dobrze.",
            "Zajmij strażników w czasie zmiany."
            } },

            { "Text.Quest.WorkplaceDistraction", new List<string> {
            "Zrób zamieszanie podczas pracy – muszę coś przenieść.",
            "Odwróć uwagę strażników w robocie.",
            "Zrób hałas w pracy, żebym mógł działać.",
            "Zrób mały incydent w czasie zmiany."
            } },

            { "Text.Quest.WorkplaceBeatdown", new List<string> {
            "Załatw typa w jego miejscu pracy.",
            "Pokaż mu, kto tu rządzi – najlepiej w czasie zmiany.",
            "Zrób z nim porządek podczas pracy.",
            "Niech dostanie nauczkę tam, gdzie zarabia."
            } },

            { "Text.Quest.WorkplaceDeliveryDriver", new List<string> {
            "Podczas pracy dostarcz to do innego więźnia.",
            "Zrób kurs po cichu – dostarcz tę paczkę w czasie pracy.",
            "Dostarcz to podczas zmiany roboczej.",
            "Zrób małą dostawę, zanim ktoś zauważy."
            } },



            { "Text.Quest.StolenGoods.Desc", new List<string> {
                "$ItemSpawnLocation wsadził swoje brudne łapy do mojego biurka i zwinął mój $ItemToGet!\\n\\nZapłaciłem za to niemałe pieniądze i chcę to natychmiast odzyskać!",
                "$ItemToGet został podprowadzony z mojego biurka, a na mieście mówią, że to robota $ItemSpawnLocation.\\n\\nBądź kumplem i odzyskaj to, co moje?",
                "Widziałem, jak $ItemSpawnLocation grzebał w moich kieszeniach po tym, jak przegrałem walkę.\\n\\nMógłbyś odzyskać mój $ItemToGet?",
                "Ten bezczelny drań $ItemSpawnLocation zaprzecza, że ukradł mój $ItemToGet!\\n\\nWiem, że go ma – mógłbyś to zbadać i odzyskać przedmiot?",
                "$ItemSpawnLocation był ewidentnie zazdrosny o mój $ItemToGet – ale nie spodziewałem się, że mnie zdradzi i go ukradnie!\\n\\nOdzyskasz go dla mnie?",
                "Zalegam z długiem u $ItemSpawnLocation, więc zabrał mi $ItemToGet w ramach spłaty.\\n\\nAle bardzo chciałbym go odzyskać…",
                "Dałem $ItemSpawnLocation mój $ItemToGet z dobroci serca, ale od razu tego pożałowałem.\\n\\nNie mam odwagi poprosić o zwrot – może ty mógłbyś to zrobić za mnie?",
                "Ktoś włamał się do mojego biurka i zabrał $ItemToGet! Założę się, że to $ItemSpawnLocation.\\n\\nMógłbyś to odzyskać?",
                "Dowiedziałem się, że $ItemSpawnLocation oszukał mnie i wyłudził $ItemToGet w ustawionej grze w karty.\\n\\nOdzyskaj to dla mnie?",
                "Po dokładnym śledztwie wyszło, że to $ItemSpawnLocation zwinął mój $ItemToGet.\\n\\nProblem w tym, że nie odda go dobrowolnie…"
            } },
            { "Text.Quest.TheArmsDealer.Desc", new List<string> {
                "Planuję w najbliższych dniach kilka solidnych rozpraw z wrogami.\\n\\nPotrzebuję jednak dobrych broni – pomożesz mi je zebrać?",
                "Ja i moi ludzie planowaliśmy przejęcie terytorium, ale strażnicy znaleźli i skonfiskowali nasz cały arsenał!\\n\\nPlan się nie zmienił – potrzebujemy tylko nowych broni. Pomożesz?",
                "Czujesz napięcie w powietrzu? Ludzie są gotowi do buntu! Nie chcę być nieprzygotowany.\\n\\nMógłbyś pomóc mi zdobyć trochę broni?",
                "Gdy idę do walki, lubię mieć szeroki wybór broni.\\n\\nNa razie mam mało opcji, chciałbym to zmienić – może z twoją pomocą?",
                "Jak ma się rozkręcić mój biznes z handlem bronią, skoro nie mam żadnego towaru?\\n\\nPomóż mi znaleźć trochę broni, a odwdzięczę się."
            } },
            { "Text.Quest.TheBeatdown.Desc", new List<string> {
                "$CombatTarget pokazał prawdziwe oblicze i doniósł na mnie strażnikom. Daj mu nauczkę!",
                "$CombatTarget próbuje wspiąć się po szczeblach naszej paczki. Nikt mnie nie przyćmi!\\n\\nChyba czas na solidne lanie!",
                "Znów mam kłopoty przez gadatliwość $CombatTarget.\\n\\nMógłbyś zamknąć mu usta pięścią?",
                "$CombatTarget próbował mnie oszukać trefnym towarem.\\n\\nZrób z tym porządek, dobra?",
                "Ten cwaniak $CombatTarget wciąż nie oddał mi długu!\\n\\nCo powiesz na szybkie lanie?",
                "Mówiłem $CombatTarget, że nie jestem zainteresowany, ale ten nie przestaje się narzucać!\\n\\nMała nauczka dobrze mu zrobi.",
                "Mam trochę wolnego czasu…\\n\\nJeśli chcesz mnie rozbawić, sprałbyś $CombatTarget.",
                "Aż się gotuję! Ostrzegałem $CombatTarget, co się stanie, jeśli mnie zdradzi.\\n\\nIdź i naucz go rozumu!",
                "Zgadnij co? Przyłapałem $CombatTarget na grzebaniu w moim biurku!\\n\\nNie znam lepszej nagrody niż porządne lanie. Jesteś chętny?",
                "Wiesz co? Dla dobra wszystkich $CombatTarget powinien dostać porządne baty.\\n\\nDasz radę to załatwić?"
            } },
            { "Text.Quest.TheChef.Desc", new List<string> {
                "Zrób mi $ItemToGet, żeby uciszyć mój głód, dobra?",
                "Koniec zmartwień! Lekarze dali mi zielone światło, czas świętować!\\n\\nPrzyrządź mi $ItemToGet!",
                "Mam nagłą ochotę na $ItemToGet.\\n\\nWiesz, gdzie mogę coś takiego dostać?",
                "Urządzam dziś małe prywatne przyjęcie w celi i potrzebuję $ItemToGet.\\n\\nMożna na ciebie liczyć?",
                "Słyszysz, jak burczy mi w brzuchu?\\n\\nPilnie potrzebuję $ItemToGet!",
                "Jestem głodny, przynieś mi $ItemToGet, dobra?",
                "Moja przekąska o północy to zawsze $ItemToGet.\\n\\nZrobisz mi jedną?",
                "Po tym, co serwują w stołówce, trudno się dziwić, że mam ochotę na $ItemToGet!\\n\\nWiesz, gdzie mogę zdobyć taki przysmak?"
            } },
            { "Text.Quest.TheConductor.Desc", new List<string> {
                "Ja i zespół mieliśmy kończyć album, ale jakieś beztalencia wyrzuciły nasze instrumenty do zsypu!\\n\\nBez instrumentów nie ma zespołu… Pomożesz nam?",
                "Pewnego dnia wrócimy na scenę i będziemy grać jak dawniej.\\n\\nPomógłbyś nam zdobyć nowe instrumenty, żeby się 'nastroić'?",
                "Pracujemy z ekipą nad drugim albumem…\\n\\nTyle że nasze stare graty się rozpadły, więc potrzebujemy nowych. Pomożesz?",
                "Nie mogę się pozbyć tej melodii z głowy, przez nią nie spałem całą noc!\\n\\nZdobądź mi instrumenty, żebym mógł to z siebie wyrzucić!",
                "Złe wieści!\\n\\nStrażnicy skonfiskowali wszystkie nasze instrumenty. Mówią, że źle graliśmy, ale co oni tam wiedzą?\\n\\nPomożesz nam zdobyć nowe sprzęty, żeby znów grać?"
            } },
            { "Text.Quest.TheDistraction.Desc", new List<string> {
                "Z powodów, o których nie będę mówić, nie mogę się pokazać podczas następnego $RuckusType.\\n\\nZrób zamieszanie, a dobrze ci zapłacę.",
                "Mam ważne, ale podejrzane spotkanie w czasie następnego $RuckusType.\\n\\nOdwrócisz uwagę strażników?",
                "Mam oko na nowy zegarek, ale to trudna kradzież.\\n\\nZrób zamieszanie podczas $RuckusType, żebym miał więcej czasu.",
                "Wypatrzyłem niezły łup, ale zdobycie go jest ryzykowne.\\n\\nJeśli zrobisz zamieszanie w czasie $RuckusType, wymknę się niezauważony.",
                "Mam do ciebie prośbę…\\n\\nZrób zamieszanie podczas $RuckusType, żeby strażnicy nie widzieli moich rąk w nie swoich kieszeniach.",
                "Odwrócisz uwagę strażników w czasie $RuckusType, żebym mógł przyłożyć mojemu rywalowi?",
                "Nie mogę realizować moich planów, gdy strażnicy patrzą!\\n\\nZrób zamieszanie podczas $RuckusType, żebym mógł działać.",
                "Hej, chcesz zarobić trochę kasy?\\n\\nZrób zamieszanie podczas $RuckusType, a ja zajmę się paroma kieszeniami!",
                "Jeśli odciągniesz uwagę w czasie $RuckusType, usunę parę nazwisk z mojej listy zemsty.\\n\\nCo ty na to?",
                "Zrób zamieszanie podczas $RuckusType, a ja załatwię swojego wroga bez świadków.\\n\\nBrzmi dobrze?"
            } },
            { "Text.Quest.TheMule.Desc", new List<string> {
                "Ten $ItemToGet to prezent dla $DeliverItemTo, ale nie chcę, żeby wiedział, że to ode mnie.\\n\\nZałatwisz to dyskretnie?",
                "Trzeba dostarczyć $ItemToGet do $DeliverItemTo, ale strażnicy mnie obserwują.\\n\\nPomożesz?",
                "Hej, masz chwilę?\\n\\nWeź ten $ItemToGet i daj go $DeliverItemTo. Jeśli strażnicy cię złapią, nie wspominaj o mnie.",
                "Mam dość jęczenia $DeliverItemTo o utraconym $ItemToGet.\\n\\nZanieś mu ten zamiennik i powiedz, że go znalazłeś.",
                "Tonę w zamówieniach i nie mam czasu na dostawy!\\n\\nZanieś ten $ItemToGet do $DeliverItemTo, a ci zapłacę.",
                "Podobno dostanę łomot, jeśli nie oddam $DeliverItemTo jego $ItemToGet!\\n\\nMógłbyś to za mnie przekazać?"
            } },
            { "Text.Quest.TheSuckUp.Desc", new List<string> {
                "Stało się – dostałem wezwanie! Awans w końcu się szykuje.\\n\\nMuszę mieć czysty $Uniform na tę okazję.",
                "Muszę wyglądać elegancko na dzisiejszą randkę.\\n\\nZanieś mój $Uniform do pralni.",
                "Nie mam POJĘCIA, co to jest na moim $Uniform, ale śmierdzi okropnie.\\n\\nLepiej, żebyś go od razu wyczyścił.",
                "Mam spotkanie z Naczelnikiem i chcę zrobić wrażenie!\\n\\nSzybko, wyczyść mój $Uniform!",
                "Sam bym to zrobił, ale wtedy byłbyś znudzony, prawda?\\n\\nNo więc do roboty – wyczyść ten $Uniform!"
            } },
            { "Text.Quest.TheWetBandit.Desc", new List<string> {
                "Chciałbym zobaczyć minę $FloodTarget, gdybyś zalał mu toaletę.\\n\\nBezcenne!",
                "Byłoby naprawdę zabawnie, gdybyś zalał toaletę $FloodTarget.\\n\\nMożesz to sobie wyobrazić?",
                "Jestem pewien, że $FloodTarget ukrywa tunel ucieczkowy! Może strażnicy powinni to sprawdzić…\\n\\nMógłbyś zalać mu toaletę?",
                "Jeśli chcesz zdobyć respekt u innych, tradycją jest zalanie toalety $FloodTarget.\\n\\nZainteresowany?",
                "Kiedyś miałem opinię króla żartów… Ale ludziom znudziły się moje wyskoki z krzaków i głupie telefony. Teraz planuję wielki powrót do świata psikusów – zaczynam od zalania celi $FloodTarget! Śmieszne, co?",
                "Wiesz, co by naprawiło wszystkie krzywdy wyrządzone mi przez $FloodTarget?\\n\\nZalanie jego toalety, oczywiście! Zrób to."
            } },
            { "Text.Quest.WasteManagement.Desc", new List<string> {
                "Ten $ItemToDestroy łączy mnie z pewnym wydarzeniem, za które mogę mieć kłopoty!\\n\\nZniszcz go, proszę!",
                "Podobno dziś mają robić przeszukanie. Jeśli znajdą ten $ItemToDestroy, jestem skończony!\\n\\nPozbądź się go, błagam...",
                "Kupiłem ten $ItemToDestroy, a dopiero potem dowiedziałem się, że jest kradziony.\\n\\nNie będę brał za to winy – wyrzuć to!",
                "Pożyczyłem ten $ItemToDestroy od kumpla, ale mnie zdradził.\\n\\nWrzuć to do śmieci, dobra?",
                "Za każdym razem, gdy widzę ten $ItemToDestroy, przypomina mi o byłej.\\n\\nWyrzuć to z mojego życia!",
                "Moje przykrywki spalono! Ukradłem ten $ItemToDestroy z biurka i teraz mnie podejrzewają.\\n\\nPozbądź się go!",
                "Może to paranoja, ale czuję, że ktoś mnie obserwuje.\\n\\nSzybko, pozbądź się $ItemToDestroy, zanim mnie z tym złapią!",
                "Pssst… jestem magikiem. Zniszcz ten $ItemToDestroy, żeby dokończyć mój trik.\\n\\nObiecuję, że to tylko rekwizyt, a nie dowód przestępstwa, o które ktoś mnie przypadkiem podejrzewa."
            } },



        };
    }
}
