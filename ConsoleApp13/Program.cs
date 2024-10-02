namespace ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prüfen, ob es sich um ein Schaltjahr handelt.");
        Console.WriteLine("Bitte gib ein Jahr ein:");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            string resultat = CheckSchaltjahr(year);
            Console.WriteLine(resultat);
        }
        else
        {
            Console.WriteLine("Bitte gib eine gültige Zahl ein.");
        }
    }

    static string CheckSchaltjahr(int year)
    {
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            return "Das Jahr " + year + " ist ein Schaltjahr.";
        }
        else
        {
            return "Das Jahr " + year + " ist kein Schaltjahr.";
        }
    }
}