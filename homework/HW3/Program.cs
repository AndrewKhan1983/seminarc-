// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число!!!");
// int dig = Convert.ToInt32(Console.ReadLine());

// void Palindrom (int dig)
//  {
//     int first = (dig/10000);
//     int second = ((dig/1000)%10);
//     int fourth = ((dig%100)/10);
//     int fifth = dig%10;
//     if (first == fifth&&second == fourth)
//     {
//       Console.WriteLine("Палиндром");
//     }
//     else
//     {
//       Console.WriteLine("Не палиндром");
//     }
//  }
// if (dig>9999&&dig<100000)
// {
//   Palindrom(dig);
// }
// else
// {
//   Console.WriteLine("Число не пятизначное");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2)+ Math.Pow(zb-za,2)),2);
// }

// Console.WriteLine("Input coordinate x for first point");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y for first point");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate z for first point");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate x for second point");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate y for second point");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate z for second point");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,za,xb,yb,zb)}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindQuad (int x, int y)
{
        while (x>=y)
    {
        Console.WriteLine($"Куб числа {y} равен {Math.Pow(y, 3)}");
        y++;
    }
}
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int y=1;
FindQuad(n, y);