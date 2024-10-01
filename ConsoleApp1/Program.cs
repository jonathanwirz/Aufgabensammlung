using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib deine erste Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib deine zweite Zahl ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Das Ergebnis ist: " + (zahl1 + zahl2));
            Console.ReadKey();
        }
    }
}
