﻿//Задача 21. На вход координаты двух точек и находит расстояние между ними в 3д пространстве

Console.Clear();
Console.Write("Введите координату x1 =");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 =");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1 =");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2 =");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2 =");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2 =");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"  Расстояние в 3D пространстве: {Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2))} ");