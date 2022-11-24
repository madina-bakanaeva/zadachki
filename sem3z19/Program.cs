//Программа, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5)
{
    if (n2 == n4)
        Console.WriteLine("yes");
}
else
    Console.WriteLine("no");