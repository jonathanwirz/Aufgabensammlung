Console.WriteLine("Wie viele Kilometer möchtest du rennen(in km)?");
    int kilometer = Convert.ToInt32(Console.ReadLine());
if (kilometer > 42)
{
    Console.WriteLine("Das schaffst du nicht!");
    Console.ReadKey();
}
else
{
    int n = kilometer * 1000 / 400;
    Console.WriteLine($"Du musst {n} Runden laufen. Bereit für den Lauf?(Ja/Nein)");
    string antwort = Console.ReadLine();
    if (antwort == "Ja")
    {
        Console.WriteLine("Viel Erfolg!");
        int i = 0;
        while (i <= n)
        {
            Console.WriteLine($"Du läufst Runde {i}");
            i++;
        }
        Console.WriteLine("Du hast es Geschafft!");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Dann eben nicht.");
        Console.ReadKey();
    }

}

