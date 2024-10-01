Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:");
int i;
i = 10 % 5;
Console.WriteLine(i);
for (i = 1; i <= 30; i++)
{
    if (i % 5 == 0 || i % 3 == 0)
    {

        if(30 == i)
        {
            Console.WriteLine($"{i}");
        }
        else
        {
            Console.WriteLine($"{i},");
        }
    }
}