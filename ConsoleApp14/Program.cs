namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int stammBreite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int stammHoehe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int kronenHoehe = Convert.ToInt32(Console.ReadLine());

            baumZeichnen(stammBreite, stammHoehe, kronenHoehe);
        }

        static void baumZeichnen(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            kroneZeichnen(kronenHoehe);
            stammZeichnen(stammBreite, stammHoehe, kronenHoehe);

        }

        static void kroneZeichnen(int kronenHoehe)
        {
            int sterne = 1;
            int leerzeichen = kronenHoehe - 1;
            for (int i = 0; i < kronenHoehe; i++)
            {
                zeichneZeile(sterne, leerzeichen);
                sterne += 2;
                leerzeichen--;
            }
        }

        static void zeichneZeile(int sterne, int leerzeichen)
        {
            for (int i = 0; i < leerzeichen; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < sterne; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void stammZeichnen(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            for (int i = 0; i <= stammHoehe; i++)
            {
                int leerzeichen = (kronenHoehe - 1) - (stammBreite / 2);
                zeichneZeile(leerzeichen, stammBreite);
            }
            }
        }
    }
