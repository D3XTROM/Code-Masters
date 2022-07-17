using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliteli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int count = 0;
            int val;
            if (Int32.TryParse(Console.ReadLine(), out val))
            {
                
                for (int i = 1; i <= val; i++)
                    if (val % i == 0)
                    {
                        
                        count++;
                    }
                Console.WriteLine($"Количество делителей числа = {count}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ещё раз");
                Console.ReadLine();
            }

            
        }
    }
}