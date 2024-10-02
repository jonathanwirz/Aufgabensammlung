namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            DoSomething(i); 
            while (i < 5) 
            {
                DoSomething(i);
                i++;
            }
        }

        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }
    }
}