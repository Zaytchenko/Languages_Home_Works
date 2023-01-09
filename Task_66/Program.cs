// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120

Console.Clear();

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void SumElementsFromMToN(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        System.Console.WriteLine("Sum all of elements from M to N = " + sum);
        return;
    }
    sum = sum + numberM++;
    SumElementsFromMToN(numberM, numberN, sum);
}

int numberM = AddNumber("Enter a number M ");
int numberN = AddNumber("Enter a number N ");
SumElementsFromMToN(numberM, numberN, 0);