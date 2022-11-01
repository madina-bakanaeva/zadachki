//Программа, которая на вход принимает число и выдает является ли оно четным (делится ли оно на два без остатка)

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x%2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");
