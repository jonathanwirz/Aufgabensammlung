using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni"
                                , "Juli", "August", "September", "Oktober", "November", "Dezember"};

            Console.Write("Zahl eingeben: ");

            string eingabe = Console.ReadLine();

            int zahl;

            if (int.TryParse(eingabe, out zahl))
            {
                if (zahl < 1 || zahl > 12)
                {
                    Console.WriteLine("Ungültige Eingabe. Zahl zwischen 1 und 12 erwartet.");
                }
                else
                {
                    Console.WriteLine("Monat: " + monate[zahl - 1]);
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Ganzzahl erwartet.");
            }

            Console.ReadKey();
        }
    }
}
