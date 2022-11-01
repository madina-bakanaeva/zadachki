// Написать программу, которая принимает на вход три числа и выдает максимальное из этихх чисел

Console.Write ("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
max = a;
if (b > a)
   max = b;
if (c > max)
   max = c;
Console.WriteLine (max);
