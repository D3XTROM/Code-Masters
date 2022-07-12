using System;


namespace ConsoleApp6
{
    internal class Program
    {
       
        static int Main(string[] args)
        {
            Console.Write($"Ввести 2 числа, 1-е число, 2-е его степень:\t");
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("b не может быть отрицательным");
                b = int.Parse(Console.ReadLine());

            }
            double c = Math.Pow(a, b);
            Console.WriteLine(c);
            return (int)c;
            
        }
    }
}