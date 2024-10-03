using System.Text;
namespace Waldbrand;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Wie tief soll der Wald sein ?");
        int breite = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wie breit soll der Wald sein ?");
        int tiefe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mit welcher Wahrscheinlichkeit sollen sich Bäume entzünde?");
        int wahrscheinlichkeit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wachstum:");
        int wachstum = Convert.ToInt32(Console.ReadLine());
        string[,] wald = WaldErstellen(tiefe, breite);
        while (true)
        {
            WaldZeichnen(wald);
            wald = neuerWald(wald, wahrscheinlichkeit, wachstum);
            Thread.Sleep(1000);
        }

    }

    static string RandomEmoji()
    {
        string[] emoji = { "🌳 ", "🟫 ", "🪨 " };
        Random rand = new Random();
        int index = rand.Next(emoji.Length);
        string randomEmoji = emoji[index];
        return randomEmoji;
    }

    static string[,] WaldErstellen(int tiefe, int breite)
    {
        string[,] wald = new string [tiefe, breite];
        for (int i = 0; i < tiefe; i++)
        {
            for (int j = 0; j < breite; j++)
            {
                wald[i, j] = RandomEmoji();
            }
        }

        return wald;
    }

    static void WaldZeichnen(string[,] wald)
    {
        StringBuilder terrainString = new StringBuilder();

        for (int i = 0; i < wald.GetLength(1); i++)
        {
            for (int j = 0; j < wald.GetLength(0); j++)
            {
                terrainString.Append(wald[j, i]);
            }

            terrainString.AppendLine();
        }
        Console.Clear();
        Console.Write(terrainString.ToString());
    }

    static string[,] neuerWald(string[,] wald, int wahrscheinlichkeit, int wachstum)
    {
        string[,] neuerWald = new string[wald.GetLength(0), wald.GetLength(1)];
        for (int i = 0; i < wald.GetLength(0); i++)
        {
            for (int j = 0; j < wald.GetLength(1); j++)
            {   
                int random = new Random().Next(0, 100);
                    if (wald[i, j] == "🌳 " && (random < wahrscheinlichkeit))
                    {
                        neuerWald[i, j] = "🔥 "; 
                    }
                    else if (wald[i, j] == "🟫 " && (random < wachstum))
                    {
                        neuerWald[i, j] = "🌳 ";
                    }
                    else if(BrenntBaumNebenAn(wald,i,j) == true && wald[i,j]=="🌳 ")
                    {
                        neuerWald[i, j] = "🔥 ";
                    }
                    else if(BrennenAlleBäumeNebenAn(wald, i, j) ==true && wald[i,j]=="🔥 ")
                    {
                        neuerWald[i, j] = "🔺 ";
                    }
                    else if(wald[i, j] == "🔺 ")
                    {
                        neuerWald[i, j] = "🟫 ";
                    }
                    else
                    {
                        neuerWald[i, j] = wald[i, j];
                    }
                
            }
        }

        return neuerWald;
    }

    static bool BrenntBaumNebenAn(string[,] wald, int i, int j)
    {
        int tiefe = wald.GetLength(0);
        int breite = wald.GetLength(1);
        
        if (i > 0 && wald[i - 1, j] == "🔥 ") 
            return true;
        if (i < tiefe - 1 && wald[i + 1, j] == "🔥 ") 
            return true;
        if (j > 0 && wald[i, j - 1] == "🔥 ") 
            return true;
        if (j < breite - 1 && wald[i, j + 1] == "🔥 ") 
            return true;
        
        if (i > 0 && j > 0 && wald[i - 1, j - 1] == "🔥 ") 
            return true;
        if (i > 0 && j < breite - 1 && wald[i - 1, j + 1] == "🔥 ") 
            return true;
        if (i < tiefe - 1 && j > 0 && wald[i + 1, j - 1] == "🔥 ") 
            return true;
        if (i < tiefe - 1 && j < breite - 1 && wald[i + 1, j + 1] == "🔥 ") 
            return true;

        return false;
    }
    static bool BrennenAlleBäumeNebenAn(string[,] wald, int i, int j)
    {
        int tiefe = wald.GetLength(0);
        int breite = wald.GetLength(1);
        
        if (
            (i > 0 && (wald[i - 1, j] == "🔥 " || wald[i - 1, j] == "🪨 " || wald[i - 1, j] == "🟫 " || wald[i - 1, j] == "🔺 ") || i == 0) &&
            (i < tiefe - 1 && (wald[i + 1, j] == "🔥 " || wald[i + 1, j] == "🪨 " || wald[i + 1, j] == "🟫 " || wald[i + 1, j] == "🔺 ") || i == tiefe - 1) &&
            (j > 0 && (wald[i, j - 1] == "🔥 " || wald[i, j - 1] == "🪨 " || wald[i, j - 1] == "🟫 " || wald[i, j - 1] == "🔺 ") || j == 0) &&
            (j < breite - 1 && (wald[i, j + 1] == "🔥 " || wald[i, j + 1] == "🪨 " || wald[i, j + 1] == "🟫 " || wald[i, j + 1] == "🔺 ") || j == breite - 1) &&
            (i > 0 && j > 0 && (wald[i - 1, j - 1] == "🔥 " || wald[i - 1, j - 1] == "🪨 " || wald[i - 1, j - 1] == "🟫 " || wald[i - 1, j - 1] == "🔺 ") || (i == 0 || j == 0)) &&
            (i > 0 && j < breite - 1 && (wald[i - 1, j + 1] == "🔥 " || wald[i - 1, j + 1] == "🪨 " || wald[i - 1, j + 1] == "🟫 " || wald[i - 1, j + 1] == "🔺 ") || (i == 0 || j == breite - 1)) &&
            (i < tiefe - 1 && j > 0 && (wald[i + 1, j - 1] == "🔥 " || wald[i + 1, j - 1] == "🪨 " || wald[i + 1, j - 1] == "🟫 " || wald[i + 1, j - 1] == "🔺 ") || (i == tiefe - 1 || j == 0)) &&
            (i < tiefe - 1 && j < breite - 1 && (wald[i + 1, j + 1] == "🔥 " || wald[i + 1, j + 1] == "🪨 " || wald[i + 1, j + 1] == "🟫 " || wald[i + 1, j + 1] == "🔺 ") || (i == tiefe - 1 || j == breite - 1))
        )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


