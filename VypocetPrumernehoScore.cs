using System;

namespace VypocitPrumerneScore
{
    class Program
    {
        static void Main(string[] args)
        {
             prumerneSkore();   
        }
        public static void prumerneSkore()
        {
            //Zadani poctu zaku co se ucastnily testu
            Console.WriteLine("Zadejte pocet studenti co psalo test");
            int velikostTridy = Convert.ToInt32(Console.ReadLine());
            //deklarace promennych
            Console.WriteLine("Zadejte maximalni mozne dosazitelne score");
            int maxScore= Convert.ToInt32(Console.ReadLine());
            int score=0;
            int pocetstudentu=0;
            int vysledek=0;

            while (pocetstudentu!=velikostTridy)
            {
                //try catch blok pro kontrolu ze zadany input je skutecne INTEGER
                try
                {
                    //Zadani skore ktereho zak dosahl
                    Console.WriteLine("Zadej skore");
                    int input =Convert.ToInt32(Console.ReadLine());
                    // Maximalni skore je 20, pokud je cislo vetsi jak 20, nebo zaporna hodnota neprida se 
                    if (input > 0&&input<(maxScore+1)&&input!=null) { 
                        Console.WriteLine("Zadane skore {0}", input);
                    score = score + input;
                    pocetstudentu++;
                    //Ukaze nam pocet zaznamu
                        Console.WriteLine("Aktualni pocet zaznamu je {0}",pocetstudentu);


                    }
                    else
                    {
                        Console.WriteLine("Zadej platne cislo");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("spatne zadany format znamky!!!") ;
                }
            }
            //Finalni vypocet prumerneho skore ktereho studenti dosahli pri testu
            Console.WriteLine(score);
            vysledek = score / pocetstudentu;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Test psalo {0} studenti",velikostTridy);
            Console.WriteLine("Prumerne score studentu je {0}",vysledek);
            Console.ReadKey();

        }
    }
}
