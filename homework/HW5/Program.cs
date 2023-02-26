//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void EvenNumber (int [] array)
// {
//     int number = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i] %2 == 0) number ++;
//     }
//   Console.WriteLine($"количество положительных чисел {number}");  
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// EvenNumber(myArray);


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void EvenIndexSummary (int [] array)
// {
//     int number = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//       if (i % 2 != 0) number +=array[i];
//     }
//   Console.WriteLine($"сумма элементов стоящих на нечетных индексах {number}");  
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// EvenIndexSummary(myArray);



// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0;i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MaxMinRazn (int [] array)
{
    int min = array[0];
    int max = array[0];
    int razn = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min>array[i])
        {
            min = array[i];
            // Console.WriteLine($"Минимальное значение {min}");
        }
        if (max<array[i])
        {
            max = array[i];
            // Console.WriteLine($"Максимальное значение {max}");
        }
    }

  Console.WriteLine($"разница между макс и мин {razn = max - min}");  
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
MaxMinRazn(myArray);
