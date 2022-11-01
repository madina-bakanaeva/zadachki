//Программа, которая на вход принимает число, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    if (i % 2==0)
Console.Write(i + " ");

