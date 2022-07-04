using System;
int k = int.Parse(Console.ReadLine());
int h = k / 3600;
int m = (k - h * 3600)/60;
Console.WriteLine($"It is {h} hours {m} minutes");