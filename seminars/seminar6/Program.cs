// Задача 1. Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length -i - 1];
//         array[array.Length -i - 1] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// int[]reverseArray = ReverseArray(myArray);
// ShowArray(reverseArray);

//Задача 2. Напишите программу, которая принимает на вход три 
//числа и проверяет, может ли существовать треугольник с сторонами 
//такой длины. самое важное знать правило, каждая сторона должна 
//быть меньше (строго) суммы двух других сторон

// bool CheckTriangle (int x, int y, int z)
// {
//     if ((x<y+z) && (y<z+x) && (z<x+y))
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Input lenght of a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of c");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Can Triangle with sides {a} and {b} and {c} exist ? {CheckTriangle(a, b, c)}");

//Задача 3. Не используя рекурсию, выведите первые N  чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Fibonacci (int size, int a, int b)
// {
//     int [] myarray = new int[size];
//     myarray[0] = a;
//     myarray[1] = b;
//     for (int i = 2; i < myarray.Length; i++)
//     {
//         myarray[i] = myarray[i-1] + myarray[i - 2];
//     }
//     return myarray;
// }

// Console.WriteLine("Input size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input lenght of b");
// int b = Convert.ToInt32(Console.ReadLine());

// int[]fibonacci = Fibonacci(size,a,b);
// ShowArray(fibonacci);

//Задача 4. **** Напишите программу, которая будет преобразовывать десятичное число в двоичное

// 45 -> 101101

// void Binary (int num) 
// {
//     string sum = string.Empty;
//     while (num > 0)
//     {
//         sum = num %2 + sum;
//         num /=2;
//     }
// Console.WriteLine(sum);
// }

// Console.WriteLine("Number");
// int num = Convert.ToInt32(Console.ReadLine());
// Binary(num);