﻿// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"quad of {num} is {quad}");

//Задача 2.

// Console.WriteLine("Input number 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;
// if(quad == num1){
//     Console.WriteLine("1 number is quad of second number");
// }
// else{
//     Console.WriteLine("1 number is  not quad of second number");
// }

//Задача 3 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);
// while (current<=num)
// {
// Console.Write(current + " ");
// current++;
// }

//Задача 4 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
    // 456 -> 6
    
    // 782 -> 2
    
    // 918 -> 8


Console.WriteLine("Input number 3 digit number");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.WriteLine($"last digit of {num} is {result}");