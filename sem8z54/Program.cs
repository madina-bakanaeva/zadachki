//54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void NewMatrix(int[,] matrix )
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
     }
}

void SotrRowInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
     {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
          if (matrix[i, k] < matrix[i, k + 1])
          {
            int temp = matrix[i, k + 1];
            matrix[i, k + 1] = matrix[i, k];
            matrix[i, k] = temp; 
          }
           
        }
        Console.Write(matrix[i, j] + "\t");
      }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: ");
NewMatrix(matrix);
Console.WriteLine("Конечный массив: ");
SotrRowInMatrix(matrix);
