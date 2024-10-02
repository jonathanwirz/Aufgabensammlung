namespace ConsoleApp18;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Bitte gib dein Geburtsdatum ein: ");
            DateTime geburtsDatum = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            TimeSpan interval = today - geburtsDatum;


            Console.WriteLine($"Alter in Jahren {interval.Days / 366}");
            Console.WriteLine($"Alter in Monate {interval.Days / 31}");
            Console.WriteLine($"Alter in Wochen {interval.Days / 7}");
            Console.WriteLine($"Alter in Tagen {interval.Days}");

        }
    }
}