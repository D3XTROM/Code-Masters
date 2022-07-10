using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ввести количество элементов массива:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ввести элемент с индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] >= 0)
                    m++;
            }
            Console.WriteLine(m);
        }
    }
}
