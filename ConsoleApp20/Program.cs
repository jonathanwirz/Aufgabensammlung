namespace ConsoleApp20;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie breit soll der Wald sein ?");
        int breite = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wie teif soll der Wald sein ?");
        int tiefe = Convert.ToInt32(Console.ReadLine());
        generiereWald(breite, tiefe);
    }
    generiereWald(int breite, int tiefe)
	{
		string[,] wald = new string[breite, tiefe];
		random random = new Random();
		string[] availableEmojis = { "🌳", "🪨", "🟫" };
		  for (int i = 0; i < arrayLength; i++)
        {
            int randomIndex = random.Next(availableEmojis.Length); // Zufälligen Index wählen
            emojis[i] = availableEmojis[randomIndex]; // Emoji in das Array einfügen
        }
	}