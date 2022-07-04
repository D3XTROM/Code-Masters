Console.WriteLine("Введите число ячеек");
int N = int.Parse(Console.ReadLine());


var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < N; i++)
{
    if (A[i] % 2 == 0)
    {
        Console.Write($"{i}");
    }

}