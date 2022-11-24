// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int Kolichestvo(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество чисел в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Количество четных чисел: {Kolichestvo(array)}");