//41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
Console.Write("Введите кол-во чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
        count = count + 1;
}
Console.WriteLine($"Количество положительных чисел: {count}");