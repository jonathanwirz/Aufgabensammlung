using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wieviele Tage hat der Monat, für den sie die Sekundenzahl berechnen wollen?");
            string input = Console.ReadLine();
            int tage = 0;

            if (!int.TryParse(input, out tage))
            {
                Console.WriteLine("Bitte geben Sie eine gültige Anzahl an Tagen ein.");
                Console.ReadKey();
            }

            if (tage == 28 || tage == 31 || tage == 29 || tage == 30)
            {
                //Berechnung der Sekunden
                int sekunden = tage * 24 * 60 * 60;

                //Ausgabe der Sekunden
                Console.WriteLine($"Ein Monat mit {tage} hat {sekunden} Sekunden.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige Anzahl an Tagen ein.");
                Console.ReadKey();
            }


        }
    }
}

