namespace ConsoleApp15;

class Program
{
    static void Main(string[] args)
    {
        Runde();

        while (true)
        {
            Console.WriteLine("Noch einmal spielen ?[y/n]");
            string antwort = Console.ReadLine();
            if (antwort == "y")
            {
                Runde();
            }
            else
            {
                break;
                Console.ReadKey();  
            }
        }
    }

    static void Runde()
    {
        //Zufällige Zahl generiern
        Random rnd = new Random();
        int zufälligeZahl = rnd.Next(1, 100);

        //Um zu Testen Zahl ausschreiben
        Console.WriteLine(zufälligeZahl);


        Console.WriteLine("Deine Zahl 1...100:");
        int versuche = 0;
        int eingegebneZahl = Convert.ToInt32(Console.ReadLine());
        versuche++;
        while (true)
        {

            if (zufälligeZahl == eingegebneZahl)
            {
                Console.WriteLine($"Die Zahl stimmt! Du hast {versuche} Versuche benötigt.");
                break;
            }
            if (zufälligeZahl > eingegebneZahl)
            {
                Console.WriteLine("Zahl ist zu klein! Nächster Versuch:");
                eingegebneZahl = Convert.ToInt32(Console.ReadLine());
                versuche++;

            }

            if (zufälligeZahl < eingegebneZahl)
            {
                Console.WriteLine("Zahl ist zu gross! Nächster Versuch:");
                eingegebneZahl = Convert.ToInt32(Console.ReadLine());
                versuche++;

            }
        }
    }
    }
    
