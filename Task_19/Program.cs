//принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да 

Console.Clear();

void СomparisonOfReversNumber(int number1)
{
    int number2 = (number1 % 10 * 10000) + (number1 / 10 % 10 * 1000) + (number1 / 100 % 10 * 100) + (number1 / 1000 % 10 * 10) + (number1 / 10000 % 10);
    if (number2 == number1)
    {
        Console.Write("-> да");
    }
    else
        Console.Write("-> нет");
}

int NumberEntry(string str)
{
    Console.Write(str);
    int number1 = int.Parse(Console.ReadLine());
    return number1;
}

int number1 = NumberEntry("Введите пятизначное число: ");
СomparisonOfReversNumber(number1);