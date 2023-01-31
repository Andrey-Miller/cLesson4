// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string[] InputArray(string str)
{
    string arg;
    while (true)
    {
        Console.Write(str);
        arg = Console.ReadLine();
        string[] array = arg.Split(' ');
        if (array.Length==8)
        {   
            return array;
        }
        System.Console.WriteLine("Неправильное кол-во символов, повторите ввод");
    }
    
}

string[] array = InputArray("Введи 8 символов через пробел: ");
System.Console.Write($"Массив из 8 элементов: ");
Console.WriteLine("[{0}]", string.Join(", ", array));