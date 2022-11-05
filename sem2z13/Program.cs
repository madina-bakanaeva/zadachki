//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
while (n < 100)
{
    Console.WriteLine("Нет третьей цифры.");
}
if (n > 99 && n < 1000)
    n1 = n % 10;
else
    do
    {
        n = n / 10;
        n1 = n % 10;
    }
    while (n > 999);
Console.WriteLine($"Третья цифра:{n1}");
*/

Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 1000)
{
    n = n / 10;
}
if (n < 100)
{
    Console.WriteLine("Не трехзначное число.");
}
else
{
    Console.WriteLine($"Третье число {n % 10}");
}