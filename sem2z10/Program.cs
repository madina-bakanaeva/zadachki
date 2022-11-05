//Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

/*

//первый скрипт без проверки на трехначность:

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число: {a = (a / 10) % 10}");
*/
/*
//второй скрипт с проверкой, но почему-то не получается решить вопрос с 4х значным числом, пишет,что не трехначное, но второе число показывает:
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 999)
    Console.WriteLine("Число не трехзначное.");
if (a < 99)
    Console.WriteLine("Число не трехзначное.");
if (a > 99)
    Console.WriteLine($"Второе число: {a = (a / 10) % 10}");
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n > 100)
{
    n = n/10;
}
Console.WriteLine($"Второе число: {n % 10}");