﻿//Задание1.  Напишите программу,
//которая принимает на вход координаты
//точки (X и Y), причём X ≠ 0 и Y ≠ 0
//и выдаёт номер четверти плоскости,
//в которой находится эта точка.

// int FindQuart (double x, double y)
// {
//     if (x>0 && y>0) return 1;
//     if (x<0 && y>0) return 2;
//     if (x<0 && y<0) return 3;
//     if (x>0 && y<0) return 4;
    
//     return 0;
// }

// Console.WriteLine("Input x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input x");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindQuart(x, y));

//Задача 3. Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2)),2);
// }

// Console.WriteLine("Input coordinate x for first point");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y for first point");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate x for second point");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y for second point");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,xb,yb)}");

//Задача 2.Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в 
//этой четверти (x и y).

// void FindDiapason (int quart)
// {
//     if (quart == 1) Console.WriteLine("x>0;y>0");
//     if (quart == 2) Console.WriteLine("x<0;y>0");
//     if (quart == 3) Console.WriteLine("x<0;y<0");
//     if (quart == 4) Console.WriteLine("x>0;y<0");

// }
// Console.WriteLine("QUART");
// int quart = Convert.ToInt32(Console.ReadLine());
// FindDiapason(quart);

//Задача 4. Напишите программу которая 
//принимает на вход число (N) и выдает 
//на консоль квадраты чисел от 1 до N

void FindQuad (int x, int y)
{
        while (x>=y)
    {
        Console.WriteLine($"Корень числа {y} равен {Math.Pow(y, 2)}");
        y++;
    }
}
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int y=1;
FindQuad(n, y);