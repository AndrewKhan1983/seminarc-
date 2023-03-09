// Задайте двумерный массив. Напищите программу, которая поменят местами первую и последнюю строку массива

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

// int[,] ChangeRows (int[,]array, int row1, int row2)
// {
//     row1--;
//     row2--;
//     if(row1>array.GetLength(0)||row2>array.GetLength(0)|| row1<0 ||row2<0){
//         Console.WriteLine("Invalid rows");
//         return array;
//     }
//     else
//     {
//         for (int j = 0; j < array.GetLength(1);j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//     } 
//     return array;
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row to change:");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of second row to change:");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,]myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = ChangeRows(myArray,row1,row2);
// Show2DArray(myArray);

// Задайте двумерный массив. Напищите программу, которая 
//изменяет строки на столбцы. В случае, если это 
//невозможно, программа должна вывести сообщение

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

// int[,] RowsToColumns (int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Row and column count mismatch");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0)-1;i++)
//         {
//             for (int j = i+1; j < array.GetLength(1);j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,]myArray = Create2DRandomArray(columns,rows,minValue,maxValue);
// Show2DArray(myArray);
// Show2DArray(RowsToColumns(myArray));


// 

int[,] Create2DRandomArray(int columns,
 int rows, int minValue, int maxValue)
{
    int [,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] DeleteMinElement(int[,] array)
{
    int min = array[0,0];
    int rowMin = 0;
    int columMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            if (array[i, j]<min)
            {
                min = array[i, j];
                rowMin = i;
                columMin = j;
            }
        }
    }
    //обнуление столбца
    for (int i = 0;i<array.GetLength(0);i++)
    {array[i,columMin]=0;}
    //обнуление строки
    for (int j = 0;j <array.GetLength(1);j++)
    {array[rowMin,j]=0;}
    return array;
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,]myArray = Create2DRandomArray(columns,rows,minValue,maxValue);
Show2DArray(myArray);
Show2DArray(DeleteMinElement(myArray));