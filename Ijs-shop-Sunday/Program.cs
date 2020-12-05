using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijs_shop_Sunday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij ijsshop: Sundays");
            Ijs ijs1 = new Ijs();
            ijs1.toString();
            bool herhalen = true;
            while (herhalen)
            {
                Console.WriteLine("Wilt u het ijsje veranderen?");
                Console.WriteLine("kies ja of nee");
                try
                {
                    string keuze = Console.ReadLine();
                    if (keuze == "ja")
                    {
                        Console.WriteLine("Wat wilt u veranderen");
                        Console.WriteLine("Kies smaak, topping of hoorn");
                        string[] ijskeuze = { "smaak", "topping", "hoorn" };
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ijskeuze[i]}");
                        }
                        int antwoord = int.Parse(Console.ReadLine());
                        string veranderingKeuze = ijskeuze[antwoord - 1];
                        if (veranderingKeuze == "smaak")
                        {
                            ijs1.smaakVerandern();
                            ijs1.toString();
                        }
                        else if (veranderingKeuze == "topping")
                        {
                            ijs1.toppingVerandern();
                            ijs1.toString();
                        }
                        else if (veranderingKeuze == "hoorn")
                        {
                            ijs1.hoornVerandern();
                            ijs1.toString();
                        }
                    }
                    else if (keuze == "nee")
                    {
                        Console.WriteLine("Oke, uw bestelling is aan de balie op te halen");
                        herhalen = false;
                    }
                    else
                    {
                        Console.WriteLine("je mag alleen ja of nee kiezen");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Er is een fout opgetreden. Maak gebruik van het juiste format");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Er is een fout opgetreden. De bestelling wordt afgesloten");

                }
            }
            Console.ReadLine();

        }
    }
}
