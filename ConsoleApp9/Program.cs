namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quersumme einer Zahl berechnen");
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int resultat = BerechneQuersumme(zahl);
            Console.WriteLine($"Die Quersumme ist: {resultat}");

        }
        static int BerechneQuersumme(int zahl)
        {
           int summe = 0;
            while (zahl != 0)
            {
                summe += zahl % 10;
                zahl /= 10;
            }
            return summe;
        }
    }
}
