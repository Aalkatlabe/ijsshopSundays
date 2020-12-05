using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ijs_shop_Sunday
{
    class Ijs
    {
        public string smaak = "vanille";
        public string topping = "geen topping";
        public string hoorn = "middel";

        public void toString()
        {
            Console.WriteLine($"Het ijsje heeft de smaak {smaak}, heeft {topping} en heeft een {hoorn} hoorn.");
        }
        public void smaakVerandern()
        {
            Console.WriteLine("Welke smaak wilt u hebben!");
            string[] smaken = { "Vanille", "Chocola", "Aardbei" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {smaken[i]}");
            }
            int antwoord = int.Parse(Console.ReadLine());
            string keuze = smaken[antwoord - 1];
            smaak = keuze;

        }
        public void toppingVerandern()
        {
            Console.WriteLine("Welke topping wilt u hebben!");
            string[] toppings = { "banaan", "discodip", "chocoladesaus" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {toppings[i]}");

            }
            int antwoord = int.Parse(Console.ReadLine());
            string keuze = toppings[antwoord - 1];
            topping = keuze;
        }
        public void hoornVerandern()
        {
            Console.WriteLine("Welke hoorn wilt u hebben!");
            string[] hoorns = { "klein", "middel", "groot" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {hoorns[i]}");

            }
            int antwoord = int.Parse(Console.ReadLine());
            string keuze = hoorns[antwoord - 1];
            hoorn = keuze;
        }
    }
}
