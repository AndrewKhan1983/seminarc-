﻿//Напишите программу, которая выводит 
//случайное число из отрезка [10, 99] и 
//показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// void MaxDecimal (int num)
// {
//     int ed = num %10;
//     int dec = num / 10;
//     if(ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}");
//     }
// }

// int num = new Random().Next(10,99+1);

// MaxDecimal(num);

// Напишите программу, которая выводит
//  случайное трёхзначное число и удаляет 
//  вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int DeleteDecimal (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot*10 + ed;
// }

// int randomnumber = new Random().Next(100,1000);
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(randomnumber));

// Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// void Metod (int num1, int num2)
// {
//     if(num1%num2 == 0)
//     {
//     Console.WriteLine($"число {num2} кратно числу{num1}");
//     }
// else
// {
//     Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток от деления {num1%num1}");    
// }
// }
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Metod (num1, num2); 



// Напишите программу, которая принимает
//  на вход число и проверяет, кратно ли
//   оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

void Kratn (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($" Число {num} делится на 7 и 23");
    }
    else
    {
        Console.WriteLine($" Число {num} не делится на 7 и 23");  
    }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Kratn(num);

// void Kratn (int num)
// {
//     if (num % 7 == 0 & num % 23 == 0)
//     {
//         Console.WriteLine($" Число {num} делится на 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine($" Число {num} не делится на 7 и 23");
//     }
// }
// Console.WriteLine("Введите число");
// int num23 = Convert.ToInt32(Console.ReadLine());
// Kratn(num23);