// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string InputNumber(string str)
{
    int number;
    string arg;
    while (true)
    {
        Console.Write(str);
        arg = Console.ReadLine();
        if (int.TryParse(arg, out number) && number > 0)
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, повторите ввод");
    }
    return arg;
}

int SumOfDigits(string num)
{   
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        result = result + (int) Char.GetNumericValue(num[i]);
    }
    return result;
}

string number = InputNumber("Введи целое положительное число: ");
System.Console.WriteLine($"Сумма цифр в числе {number} -> {SumOfDigits(number)}");
