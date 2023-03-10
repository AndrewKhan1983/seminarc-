//Задача 1. Задайте значение N. 
//Напишите программу, которая 
//выведет все натуральные числа 
//в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers (int n)
// {
//     if (n>1)
//     {
//         ShowNumbers(n-1);
//     }
//     Console.Write(n+" ");
// }

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

//Задание 2. Напишите программу, 
//которая будет принимать на вход 
//число и возвращать сумму его цифр.

// int FindSum(int num)
// {
//     if(num>0)
//         return FindSum(num/10) + num%10;
//     else
//         return num;
// }

// Console.WriteLine(FindSum(453));


//Задача 3. Задайте значения M и N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void Shownumber (int n,int m)
// {
//     if(n!=m)
//     {

    
//     if(m<=n)
//     {
//         Shownumber(n-1,m);
//         Console.Write(n +" ");
//     }
//     else
//     {
//         Shownumber(n,m-1);
//         Console.Write(m +" ");
//     }
//     }
//     else
//     {
//         Console.WriteLine(n);
//     }
// }

// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input m");
// int m = Convert.ToInt32(Console.ReadLine());

// Shownumber(n,m);
// void ShowNumbers(int N, int M)
// {
//     if(N!=M)
//     {
//         if(M<=N)
//         {

//             ShowNumbers(N-1,M);
//             Console.WriteLine(N+" ");
        
//         }
//         else
//         {
//             ShowNumbers(N,M-1);
//             Console.WriteLine(M+" ");
//         }
//     }
//     else
//     {
//         Console.WriteLine(N);
//     }

// }

// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input N");
// int M=Convert.ToInt32(Console.ReadLine());
// ShowNumbers(N,M);



//Задача 4.Напишите программу, 
//которая на вход принимает два числа 
//A и B, и возводит число А в целую 
//степень B с помощью рекурсии.

//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int ShowNumbers (int a,int b)
{
    if (b!=0)
    {
        return ShowNumbers(a,b-1) * a;
    }
    else return 1;
}

Console.WriteLine("Input a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowNumbers(a,b));
