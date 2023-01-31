// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void InputNumbers(string str, out int num, out int pow)
{
    num = 0;
    pow = 0;
    string arg;
    while (true)
    {
        Console.Write(str);
        arg = Console.ReadLine();
        string[] args = arg.Split(' ');
        if (!(int.TryParse(args[0], out num)))
        {
            System.Console.WriteLine("Введены некорректные числа, повторите ввод");
        }
        else if (!(int.TryParse(args[1], out pow)) || Convert.ToInt32(args[1]) <= 0)
        {
            System.Console.WriteLine("Введены некорректные числа, повторите ввод");
        }
        else
        {
            break;
        }
    }

}

int Pow(int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result = result * num;
    }
    return result;
}

InputNumbers("Введи число и натуральную степень через пробел: ", out int num, out int pow);
System.Console.WriteLine($"Число {num} в степени {pow} = {Pow(num, pow)}");

