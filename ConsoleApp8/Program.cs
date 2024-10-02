using System.Reflection;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isRunning = true;
            Console.WriteLine("Um das Programm zu beenden drücke q");

            while (isRunning)
            {
                Console.WriteLine("Welche Zahl möchtest du in Binär wissen?");
                input = Console.ReadLine();

                if (input == "q")
                {
                    isRunning = false;
                }
                else
                {
                    if (int.TryParse(input, out int zahl))
                    {
                        Console.WriteLine("Die Zahl in Binär ist: " + BinearBerechnen(zahl));
                    }
                    else
                    {
                        Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    }
                }
            }

            Console.WriteLine("Das Programm wurde beendet.");
            Console.ReadKey();
        }

        static string BinearBerechnen(int zahl)
        {
            string binaer = "";

            while (zahl > 0)
            {
                binaer = (zahl % 2) + binaer;
                zahl /= 2;
            }
            return binaer;
        }
    }
}
