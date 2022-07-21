using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x; int y; //Объявляем переменные
        Console.WriteLine("Ввести 2 числа, 0 или 1:");

        x = int.Parse(Console.ReadLine()); // Объявление переменной x
        y = int.Parse(Console.ReadLine()); // Объявление переменной y

        if (x == 0 && y == 0)               // если число x = 0 и число y = 0, то выводим не правда
            Console.WriteLine("0");
        else if (x == 1 && y == 1)          // в другом случае если x = 1 и y = 1, то выводим не правда
            Console.WriteLine("0");
        else if (x == 0 && y == 1)          // в другом случае если x = 0 и y = 1, то выводим  правда
            Console.WriteLine("1");
        else Console.WriteLine("1");     // В последнем случае выводим правда
    }
}