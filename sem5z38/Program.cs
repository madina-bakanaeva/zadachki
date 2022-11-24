//  Массив вещественных чисел. Найти разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

double MaxMin(double[] array)
{
    double raznost =0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];

    }
    raznost =max -min;
    return raznost;
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Разница между max и min: {MaxMin(array)}");