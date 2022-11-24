// Программа, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введите количество элементов (8): ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

int i = 0;
while (a < 8 || a > 8)
{
    Console.WriteLine("Необходим массив из 8 элементов! Введите:");
    a = Convert.ToInt32(Console.ReadLine());
}

while (i < array.Length)
{
    Console.WriteLine("Введите " + i + " элемент массива :");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.Write(" Массив: ");
Console.WriteLine($"[{string.Join(",", array)}]");