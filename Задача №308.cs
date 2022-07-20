using System;


namespace ConsoleApp6
{
    internal class Program
    {

        static int Main()
        {
            Console.WriteLine("Ввести x и y, они должны быть ровны 1 или 0: ");
            int x; int y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
                Console.WriteLine("false");
            else if (x == 1 && y == 1)
                Console.WriteLine("false");
            else if (x == 1 && y == 0) 
                Console.WriteLine("true");
            else Console.WriteLine("true");
            return x;
        }
    }
}