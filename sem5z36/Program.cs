// Одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-75, 879);
}

int Summa (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];

    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите количество чисел в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Summa(array)}");