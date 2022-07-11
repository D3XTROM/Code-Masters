using System;


namespace ConsoleApp6
{
    internal class Program
    {
        static int Minimum(int a, int b, int c, int d)
        {

           

            if (a <= b && a <= c && a <= d)
                return a;
            else if (b <= a && b <= c && b <= d)
                return b;
            else if (c <= a && c <= d && c <= b)
                return c;
            else return d;

        }
        static void Main()
        {
            Console.WriteLine("Ввести 4 числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int min;
            min = Minimum(a, b, c, d);
            Console.WriteLine(min);
        }

    }
}
