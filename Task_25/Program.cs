// Напишите цикл, который принимает на вход два числа ( A и B)
// и возводит A в натуральную степень B

Console.Clear();

double SomeNumbers(string str)
{
    Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double numberA = SomeNumbers("Введите число A: ");
double numberB = SomeNumbers("Введите натуральную степень (B): ");
numberB = (int)numberB;
double result = 1;
for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}

Console.Write("-> " + result);
