using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{ /*enum PoziomyTrudności { łatwy,średnni,trudny}*/
    public class Gracz
    {
        public string name;
        public int zdrowie;
    }
    public class Przeciwnik
    {
        public int zdrowie;
    }
    internal class Program
    {
        public static Gracz uzytkownik = new Gracz();
        public static Przeciwnik przeciwnikm = new Przeciwnik();
        public static Przeciwnik przeciwnikl = new Przeciwnik();
        public static Przeciwnik przeciwnikh = new Przeciwnik();
        public static void Main(string[] args) 
        {

            Menu();
            PoziomRozgrywki();

            Console.WriteLine("Nazywasz się {0} masz {1} punktów zdrowia. Czas rozpocząć grę", uzytkownik.name, uzytkownik.zdrowie);
            Console.ReadLine();
            Console.Clear();
            PrzeciwnikMatematyczny();
            Console.ReadKey();
            Console.Clear();
            PrzeciwnikLekturowy();
            Console.ReadKey();
            Console.Clear();
            PrzeciwnikHistoryczny();
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Projekt z programowania obiektowego w postaci gry tekstowej");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Jak ma na imię twój bohater?");
            uzytkownik.name = Console.ReadLine();
            Console.WriteLine("witaj {0} jesteś poszukiwaczem skarbów od wielu lat poszukujesz złotego miasta i w końcu znalazłeś jego trop.", uzytkownik.name);
            Console.WriteLine("W czasie podróży czeka Cię wiele przeszkód.Wielokrotnie będziesz zmuszony do rozwiązania zagadek w celu zdobycia potrzebnych rzeczy. ");
            Console.WriteLine("Każda poprawna odpowiedź zabiera twojemu przeciwnikowi jeden punkt zdrowia");
            Console.WriteLine("Każda niepoprawna odpowiedź zabiera Tobie jeden punkt zdrowia");
            Console.WriteLine("Gdy pokonasz przeciwnika twoje zdrowie powiększa się o 1");
            Console.WriteLine("W przypadku porażki gra się kończy");

            Console.ReadKey();
        }
        public static void PoziomRozgrywki() 
        {
            Console.WriteLine("Wybierz poziom trudności.Łatwy-1, Średni-2 trudny-3");
            int zdrowie;
            zdrowie = int.Parse(Console.ReadLine());
            //uzytkownik.zdrowie = int.Parse(Console.ReadLine());
                switch (zdrowie)
                {
                    case 1:
                        uzytkownik.zdrowie = 5;
                        //Console.WriteLine("Masz 5 pkt zdrowia");

                        break;


                    case 2:
                        uzytkownik.zdrowie = 3;
                        //Console.WriteLine("Masz 3 pkt zdrowia");
                        break;

                    case 3:
                        uzytkownik.zdrowie = 2;
                        //Console.WriteLine("Masz 2 pkt zdrowia");
                        break;

                    default:
                        throw new ArgumentException("Wpisano niedozwolony znak");
                        break;


                }

            //Console.ReadKey();

            //Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);
            //Console.ReadKey();


        }

        public static void PrzeciwnikMatematyczny()
        {
            int zdrprzej = uzytkownik.zdrowie;
            początek:
            przeciwnikm.zdrowie = 3;
            uzytkownik.zdrowie = zdrprzej;
            while (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Od kilku godzin przemierasz dżungle w poszukiwaniu złotego zamku");
                Console.WriteLine("Potrzebujesz jedzenia nie masz niestety czym za nie zapłacić...");
                Console.WriteLine("W końcu natrafiasz na zamieszkałą wioskę");
                Console.WriteLine("Jeden z jej mieszkańców obiecuje Ci przygotowanie prowiantu na drogę jeśli tylko rozwiążesz jego zagadki matematyczne...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Twój przeciwnik ma {0} punkty zdrowia", przeciwnikm.zdrowie);
                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {



                    Console.WriteLine("Pierwsze pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 2+2*2");
                    Console.WriteLine("a=6      b=8     c=12    d=2");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "a")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                }
                Console.ReadKey();
                Console.Clear();

                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("Drugie Pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 6!*6");
                    Console.WriteLine("a=36      b=3350    c=4320   d=7260");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "c")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }



                }
                Console.ReadKey();
                Console.Clear();

                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("trzecie pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 16/(4 *2)");
                    Console.WriteLine("a=2      b=8   c=32   d=6");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "a")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                }

                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("czwarte pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 8*8*8 ");
                    Console.WriteLine("a=252     b=512   c=128  d=720");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "b")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }



                }
                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("piąte pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 3*3+3  ");
                    Console.WriteLine("a=27     b=18   c=9  d=12");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "d")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                }

                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("szóste pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 99+128  ");
                    Console.WriteLine("a=192    b=298   c=227  d=12672");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "c")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }



                }
                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("siódme pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 22*12  ");
                    Console.WriteLine("a=264     b=34   c=123  d=652");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "a")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }



                }
                if (uzytkownik.zdrowie > 0 || przeciwnikm.zdrowie > 0)
                {

                    Console.WriteLine("ósme");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ile wynosi 21+3  ");
                    Console.WriteLine("a=24     b=63   c=18 d=7");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp1 = Console.ReadLine();
                    if (odp1 == "a")
                    {
                        przeciwnikm.zdrowie = przeciwnikm.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikm.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikm.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                }

            }
        koniec:
            
                if (uzytkownik.zdrowie <= 0)
                {
               
                    Console.WriteLine("Niestety przgrałeś...Spróbuj ponownie");
                Console.ReadKey();
                Console.Clear();
                goto początek;

                }
                else if (przeciwnikm.zdrowie <= 0)
                {
                    Console.WriteLine("Gratulacje! Udało Ci się przejść pierwszego przecwnika kontunuuj przygodę...");
                    Console.WriteLine("Dzięki wygranej potyczce logicznej dostajesz dodatkowy punkt zdrowia.");
                    uzytkownik.zdrowie = (uzytkownik.zdrowie + 1);
                }
            

        }
        public static void PrzeciwnikLekturowy()
        {
            
            Console.WriteLine("Dzięki zdobytemu prowiantowi możesz kontynuować przygodę");
            
            

            int zdrprzej = uzytkownik.zdrowie;
            początek:
            przeciwnikl.zdrowie = 2;
            uzytkownik.zdrowie = zdrprzej;
            while (uzytkownik.zdrowie > 0 || przeciwnikl.zdrowie > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Wychodząc z wioski zaczepia Cię jakiś nieznajomy");
                Console.WriteLine("Twierdzi ,że posiada mapę do złotego miasta");
                Console.WriteLine("I odda Ci ją jeżeli odpowiesz poprawnie na jego pytania");
                Console.WriteLine("Twój przeciwnik jest emerytowanym nauczycielem języka polskiego będzie zadawał Ci pytania z tej dziedziny");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Twój przeciwnik ma {0} punkty zdrowia", przeciwnikl.zdrowie);
                if (uzytkownik.zdrowie > 0 || przeciwnikl.zdrowie > 0)
                {



                    Console.WriteLine("Pierwsze pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Kto napisał Lalkę?");
                    Console.WriteLine("a=Bolesław Prus    b=Henryk Sienkiewicz     c=Aleksander Fredro    d=Adam Mickiewicz");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    string odp2 = Console.ReadLine();
                    if (odp2 == "a")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }
                    Console.WriteLine("Drugie pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Który z poniższych utworów napisał Stanisław Wyspiański?");
                    Console.WriteLine("a=Dziady    b=Wesele     c=Krzyżacy    d=Osoba i czyn");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                     odp2 = Console.ReadLine();
                    if (odp2 == "b")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                    Console.WriteLine("Trzecie pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Jak nazywał się główny bohater Dziadów cz III");
                    Console.WriteLine("a=Marcin   b=Konrad    c=Krzysztof    d=Grzegorz");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "b")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                    Console.WriteLine("Czwarte pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Kto napisał zbrodnie i karę");
                    Console.WriteLine("a=Frank Herbert    b=Lew Tołstoj     c=J.R.R Tolkien    d=Fiodor Dostojewski");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "d")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                    Console.WriteLine("Piąte pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Jak kończy Anna Karenina w powieści o tym samym tytule?");
                    Console.WriteLine("a=Zostaje trafiona przez piorun    b=Popełnia samobójstwo      c=bierze ślub   d=Traci nogę ");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "b")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }

                    Console.WriteLine("Szóste pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Kto napisał Potop");
                    Console.WriteLine("a=Juliusz Słowacki   b=Adam Mickiewicz   c=Henryk Sienkiewicz   d=Cyprian Kamil Norwid ");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "c")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }


                    Console.WriteLine("Siódme pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("W którym wieku został napisany poemat Pan Tadeusz");
                    Console.WriteLine("a= XIX   b=XXI   c=XV   d=IX ");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "a")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }

                    Console.WriteLine("Ósme pytanie");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Który z podanych pisarzy nie jest nazywany jednym z 3 wieszczów romantyzmu? ");
                    Console.WriteLine("a=Józef Kraszewski   b=Adam Mickiewicz   c=Juliusz Słowacki   d=Zygmunt Krasińśki");
                    Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                    odp2 = Console.ReadLine();
                    if (odp2 == "a")
                    {
                        przeciwnikl.zdrowie = przeciwnikl.zdrowie - 1;
                        Console.WriteLine("Dobra odpowiedź ");
                    }
                    else
                    {
                        uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                        Console.WriteLine("zła odpowiedź ");
                    }
                    Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                    Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikl.zdrowie);
                    if (uzytkownik.zdrowie <= 0)
                    {
                        goto koniec;

                    }
                    else if (przeciwnikl.zdrowie <= 0)
                    {
                        goto koniec;
                    }

                }
               
            }
             koniec:

            if (uzytkownik.zdrowie <= 0)
            {

                Console.WriteLine("Niestety przgrałeś...Spróbuj ponownie. Na szczęście możesz zacząć od razu od ostatniego przeciwnika");
                Console.ReadKey();
                Console.Clear();
                goto początek;

            }
            else if (przeciwnikl.zdrowie <= 0)
            {
                Console.WriteLine("Gratulacje! Udało Ci się przejść drugiego przecwnika kontunuuj przygodę...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Niestety zostałeś oszukany i nauczyciel nie posiada żadnej mapy.");
                Console.WriteLine("Musisz samemu znaleźć drogę do złotego zamku.");
                Console.WriteLine("Dzięki wygranej potyczce logicznej zwiększasz swoje zdrowie o 1");
                uzytkownik.zdrowie = (uzytkownik.zdrowie + 1);
                Console.ReadKey();
            }
        }

                    public static void PrzeciwnikHistoryczny()
                    {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Po długiej podróży znajdujesz poszlakę. ");
                                Console.WriteLine("Na drzewie jest wyryty kierunek");
                                Console.WriteLine("Idąc w kierunku znajdujesz przyspyane ziemią wejśćie");
                                Console.WriteLine("Schodzisz do środka");
                                Console.WriteLine("Twoim oczom ukazuje się stwór o ciele lwa z szkrzydłami ptaka");
                                Console.WriteLine("Jeżeli rozwiążesz jego zagadki wpuści Cię do środka");
                                Console.ReadKey();
                                Console.Clear();


                                int zdrprzej = uzytkownik.zdrowie;
                                początek:
                                przeciwnikh.zdrowie = 5;
                                uzytkownik.zdrowie = zdrprzej;
                                while (uzytkownik.zdrowie > 0 || przeciwnikh.zdrowie > 0)
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    
                                    
                                    Console.WriteLine("Twój przeciwnik ma {0} punkty zdrowia", przeciwnikh.zdrowie);
                                    if (uzytkownik.zdrowie > 0 || przeciwnikh.zdrowie > 0)
                                    {



                                        Console.WriteLine("Pierwsze pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("W nocy przychodzą bez przynależności, a w dzień są zagubieni bez kradzieży.");
                                        Console.WriteLine("a=Gwiazdy    b=Słońce    c=Księżyc    d=Woda");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        string odp2 = Console.ReadLine();
                                        if (odp2 == "a")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }
                                        Console.WriteLine("Pytanie numer dwa");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Niewielki jak kciuk, jestem lekki w powietrzu, możesz usłyszeć mnie, zanim mnie zobaczysz, ale ufaj, że tam jestem.");
                                        Console.WriteLine("a= Komar   b=Trzmiel     c=Koliberek    d=Jaskółka");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "c")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }


                                        Console.WriteLine("Trzecie pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Co może biec, ale nigdy nie chodzi, ma usta, ale nigdy nie mówi, ma głowę, ale nigdy nie płacze, ma łóżko, ale nigdy nie śpi?");
                                        Console.WriteLine("a=Dziecko   b=Rzeka    c=Rydwan    d=Dywan");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "b")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }


                                        Console.WriteLine("Czwarte pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("To wszystko pożera: ptaki, zwierzęta, drzewa, kwiaty; gryzie żelazo, gryzie stal; miele twarde kamienie do posiłku; zabija królów, ruiny miast; i bije wysokie góry.");
                                        Console.WriteLine("a=Robak   b=Wilk    c=Człowiek    d=Czas");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "d")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }


                                        Console.WriteLine("Piąte pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Co zawsze jest stare, a czasem nowe; nigdy smutny, czasem niebieski; nigdy puste, ale czasami pełne; nigdy nie naciska, zawsze ciągnie?");
                                        Console.WriteLine("a=drzewo    b=Księżyc      c=słońce   d=wiadro ");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "b")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }

                                        Console.WriteLine("Szóste pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Co jest duże, ale nigdy nie rośnie; ma korzenie, których nie można zobaczyć; i wyższy niż drzewa?");
                                        Console.WriteLine("a=Wiatr   b=Człowiek   c=Góra   d=Trawa ");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "c")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }


                                        Console.WriteLine("Siódme pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Ja tworzę legowisko z ziemnym sznurkiem i wysyłam moją ofiarę z kąsającym żądłem.");
                                        Console.WriteLine("a= Pająk   b=kura   c=czas   d=śmierć ");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "a")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }

                                        Console.WriteLine("Ósme pytanie");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Jestem żywy, ale bez oddechu; Jestem tak zimny w życiu jak w śmierci; Nigdy nie jestem spragniony, chociaż zawsze piję. ");
                                        Console.WriteLine("a=Ryba  b=Człowiek   c=Śmierć  d=Lód");
                                        Console.WriteLine("Wpisz literkę z właściwą odpowiedzią");
                                        odp2 = Console.ReadLine();
                                        if (odp2 == "a")
                                        {
                                            przeciwnikh.zdrowie = przeciwnikh.zdrowie - 1;
                                            Console.WriteLine("Dobra odpowiedź ");
                                        }
                                        else
                                        {
                                            uzytkownik.zdrowie = uzytkownik.zdrowie - 1;
                                            Console.WriteLine("zła odpowiedź ");
                                        }
                                        Console.WriteLine("Twoje zdrowie wynosi " + uzytkownik.zdrowie);

                                        Console.WriteLine("Zdrowie przeciwnika wynosi " + przeciwnikh.zdrowie);
                                        if (uzytkownik.zdrowie <= 0)
                                        {
                                            goto koniec;

                                        }
                                        else if (przeciwnikh.zdrowie <= 0)
                                        {
                                            goto koniec;
                                        }

                                    }

                                }
                                        koniec:

                                            if (uzytkownik.zdrowie <= 0)
                                            {

                                                Console.WriteLine("Niestety przgrałeś...Spróbuj ponownie. Na szczęście możesz zacząć od razu od ostatniego przeciwnika");
                                                Console.ReadKey();
                                                Console.Clear();
                                                goto początek;

                                            }
                                            else if (przeciwnikl.zdrowie <= 0)
                                            {
                                                Console.WriteLine("Gratulacje! Udało Ci się przejść ostatniego przeciwnika");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("Drzwi do złotego podziemnego miasta zostały otwarte");
                                                Console.WriteLine("W środku znajduje się wiele cennych rzeczy które");
                                                Console.WriteLine("Gratulacje udało Ci się ukończyć naszą grę!");
                                                Console.WriteLine("Mamy nadzieję ,że spędzony czas minął miło");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Projekt wykonali Grzegorz Źiółek, Krzysztof Zawadzki, Marcin Samuś");
                                                //Console.WriteLine("Dzięki wygranej potyczce logicznej zwiększasz swoje zdrowie o 1");
                                                //uzytkownik.zdrowie = (uzytkownik.zdrowie + 1);
                                                Console.ReadKey();
                                }
                            }

    }

           
            

    }

   

