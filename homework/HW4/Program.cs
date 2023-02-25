// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Quad (int a, int b)
// {
//     int kvadr = 1;
//     for (int i = 0; i < b; i++)
//     {
//         kvadr = kvadr*a;
//     }
//     return kvadr;
// }
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите множитель");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = Quad(a,b);
// Console.WriteLine(result);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNumber (int num)
{

    int sum = 0;
    while(num>0)
    {
        sum=sum+num%10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumber(num));




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
