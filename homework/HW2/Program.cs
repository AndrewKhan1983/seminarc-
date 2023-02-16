//Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.


// int SecDig (int num)
// {
//     int sd = (num/10)%10;
//     return sd;
// }
// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (SecDig(num));

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThDig (int num)
// {
//     while (num>999);
//     {
//         num /= 10;
//     }
//     if (num<100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     return num%10;
// }


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ThDig(num));

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number>999)
//     {
//         number /= 10;
//     }
//     return number %10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число >");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }

//Задача 15: Напишите программу, которая принимает на вход цифру
//, обозначающую день недели, и проверяет, является ли этот день выходным.


int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekday)
{
    if ( weekday>5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number>0 && number<=7)
    {
        return true;
    }
    Console.WriteLine("Нет такого дня");
    return false;
}

int weekday = Prompt ("Введите день недели >");
if (ValidateWeekday(weekday))
{
    if (IsWeekend(weekday))
    {
        Console.WriteLine ("Выходной");
    }
    else
    {
        Console.WriteLine ("Не выходной");
    }
}