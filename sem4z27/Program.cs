//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите  число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if (a < 0)
    a = a * (-1);
while (a > 0)
{
    int n = a % 10;
    b = b + n;
    a = a / 10;
}
Console.WriteLine(b);