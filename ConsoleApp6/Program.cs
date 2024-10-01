Console.WriteLine("-------------");
Console.WriteLine("Kleines 1x1");
Console.WriteLine("-------------");

for (int i = 1; i <= 10; i++)
{
    // Innere Schleife für die Spalten (1 bis 10)
    for (int j = 1; j <= 10; j++)
    {
        // Multiplikationsergebnis mit Tabulator trennen
        Console.Write((i * j) + "\t");
    }
    // Nach jeder Zeile einen Zeilenumbruch
    Console.WriteLine();
}
Console.ReadKey();
