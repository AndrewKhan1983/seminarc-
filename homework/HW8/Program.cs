//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int columns,
//  int rows, int minValue, int maxValue)
// {
//     int [,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Sort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,]array = Create2DRandomArray(columns,rows,minValue,maxValue);
// Show2DArray(array);
// Sort(array);
// Console.WriteLine();
// Show2DArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int columns,
//  int rows, int minValue, int maxValue)
// {
//     int [,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void AverageArifmetics (int[,] array)
// {
//     int index = 0, minsum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         Console.WriteLine($"Сумма {i + 1} строки = {sum}");
//         if (i == 0)
//         {
//             minsum = sum;
//         }
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
//     string line = string.Empty;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         line += array[index, j] + " ";
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов равна {line}. ");
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,]array = Create2DRandomArray(columns,rows,minValue,maxValue);
// Show2DArray(array);
// Console.WriteLine();
// AverageArifmetics(array);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int columns,
//  int rows, int minValue, int maxValue)
// {
//     int [,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumMatrix (int[,] array1, int[,] array2)
// {
//     int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
//     if(array1.GetLength(1) == array2.GetLength(0))
//     {
//         for (int i = 0; i < array3.GetLength(0);i++)
//         {
//             for (int j = 0; j < array3.GetLength(1);j++)
//             {
//                 array3[i,j] = 0;
//                 for (int k = 0; k < array1.GetLength(1);k++)
//                 {
//                     array3[i,j] += array1[i,k] * array2[k,j];
//                 }
//             }
//         }
//     }
//     return array3;
// }

// Console.WriteLine("Input number of rows Array1");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns Array1");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of rows Array2");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns Array2");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element Array1");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element Array1");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element Array2");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element Array2");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// int[,]array1 = Create2DRandomArray(2,2,0,10);
// int[,]array2 = Create2DRandomArray(2,2,0,10);
// Show2DArray(array1);
// Show2DArray(array2);
// Console.WriteLine();
// Console.WriteLine(SumMatrix(array1,array2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
