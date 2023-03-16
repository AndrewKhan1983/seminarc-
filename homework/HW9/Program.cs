//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers (int n)
// {
//     if (n==0) return;
//     Console.Write("{0,4}",n);
//     ShowNumbers(n-1);
// }

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);




// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumNumbers(int m, int n, int sum)
{
        if(m>n)
        {
            Console.WriteLine($"Сумма чисел от m до n:{sum}");
        return;
        }
        sum = sum + (m++);
        SumNumbers(m, n, sum);
}

Console.WriteLine("Input m");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int n=Convert.ToInt32(Console.ReadLine());

SumNumbers(m,n,0);


// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
