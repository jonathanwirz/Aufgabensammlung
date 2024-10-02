namespace ConsoleApp16;

class Program
{
    static void Main(string[] args)
    {
        //Eingabe des Text
        Console.WriteLine("Deine Eingabe:");
        string text = Console.ReadLine();
        
        //Berechnung der Anzahl der Vokale
        
        int a = countLetter(text, 'a');
        int e =countLetter(text, 'e');
        int i = countLetter(text, 'i');
        int o = countLetter(text, 'o');
        int u = countLetter(text, 'u');
        int ä = countLetter(text, 'ä');
        int ö = countLetter(text, 'ö');
        int ü = countLetter(text, 'ü');
        int A = countLetter(text, 'A');
        int E = countLetter(text, 'E');
        int O = countLetter(text, 'O');
        int U = countLetter(text, 'U');
        int Ä = countLetter(text, 'Ä');
        int Ö = countLetter(text, 'Ö');
        int Ü = countLetter(text, 'Ü');
        
        //Gesamte Anzahl der Vokale
        int vokale = a + e + i + o + u + ä + ö + ü + A + E + O + U + Ä + Ö + Ü;
        
        //Ausgabe der Anzahl der Vokale
        Console.WriteLine($"Anzahl der Vokale: {vokale}");
        
        //Einzelne Ausgabe der Vokale
        if (a > 0)
        {
            Console.WriteLine($"Anzahl der a: {a}");
        }
        if (e > 0)
        {
            Console.WriteLine($"Anzahl der e: {e}");
        }
        if (i > 0)
        {
            Console.WriteLine($"Anzahl der i: {i}");
        }
        if (o > 0)
        {
            Console.WriteLine($"Anzahl der o: {o}");
        }
        if (u > 0)
        {
            Console.WriteLine($"Anzahl der u: {u}");
        }
        if (ä > 0)
        {
            Console.WriteLine($"Anzahl der ä: {ä}");
        }
        if (ö > 0)
        {
            Console.WriteLine($"Anzahl der ö: {ö}");
        }
        if (ü > 0)
        {
            Console.WriteLine($"Anzahl der ü: {ü}");
        }
        if (A > 0)
        {
            Console.WriteLine($"Anzahl der A: {A}");
        }
        if (E > 0)
        {
            Console.WriteLine($"Anzahl der E: {E}");
        }
        if (O > 0)
        {
            Console.WriteLine($"Anzahl der O: {O}");
        }
        if (U > 0)
        {
            Console.WriteLine($"Anzahl der U: {U}");
        }
        if (Ä > 0)
        {
            Console.WriteLine($"Anzahl der Ä: {Ä}");
        }
        if (Ö > 0)
        {
            Console.WriteLine($"Anzahl der Ö: {Ö}");
        }
        if (Ü > 0)
        {
            Console.WriteLine($"Anzahl der Ü: {Ü}");
        }
    }

    //Funktion um die Anzahl der Vokale zu zählen
    static int countLetter(string text, char countableLetter)
    {
        return text.Count(x => x == countableLetter);
    }
}