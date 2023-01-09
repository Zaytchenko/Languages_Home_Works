// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
Console.Clear();

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void NumberMinus(int number)
{
    if (number >= 1)
    {
        System.Console.Write($"{number}, ");
        number--;
        NumberMinus(number);
    }
}

int number = AddNumber("Enter a number N ");
NumberMinus(number);