using System;
 
namespace GenericsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> ps = new PrintService<string>();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a value: ");
                string value = Console.ReadLine();
                ps.AddValue(value);
            }

            ps.Print();
            Console.WriteLine("First: " + ps.First());

        }

    }
}