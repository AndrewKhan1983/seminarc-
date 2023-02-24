// Задача 1 Напишите программу которая принимает на вход число (А) и выдает сумму чисел от 1 до А

// int FindSumm (int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++)
//     {
//         sum = sum + current; // sum+=current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSumm(a));

// Задача 4 Напищите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

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

//Задача 2 Напишите программу которая принимает на вход число и выдает количество цифр в числе

// int CountNumber (int num)
// {
//     int count = 0;
//     while(count<num)
//     {
//         num = num/10;
//         count ++;
//     }
//     return count;
// }
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumber(num));

//Задача 3 Напищите программу которая принимает на вход число N и выдает произведениечисел от 1 до N

int Factor (int num)
{
    int n = 1;
    for (int i = 1; i <= num; i++)
    {
        n=n*i;
    }
    return n;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factor(num));