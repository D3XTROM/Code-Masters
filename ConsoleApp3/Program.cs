Console.WriteLine("Написать 4 числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
if (a <= b && a <= c && a <= d)
    Console.WriteLine(a);
else if (b <= c && b <= d && b <= a)
    Console.WriteLine(b);
else if (c <= d && c <= a && c <= b)
    Console.WriteLine(c);
else Console.WriteLine(d);
    
