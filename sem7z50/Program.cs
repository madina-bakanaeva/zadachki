//50. Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
Console.WriteLine("Введите № строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите № столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
void FindIndexMatrix(int[,] matrix)
{
    if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[m - 1, n - 1]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}
FindIndexMatrix(matrix);
