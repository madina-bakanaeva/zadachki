// Программа, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным



Console.Clear();
Console.WriteLine("Введите цифру недели:");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
    Console.WriteLine("Выходной.");
if (a < 1 || a > 7)
    Console.WriteLine("Нет такого дня.");
if (a >= 1 && a < 5)
    Console.WriteLine("Сегодня будний день.");
