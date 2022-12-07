// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел
Console.Clear();

Console.Write("Введите первое число для сравнения: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число для сравнения: ");

int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число для сравнения: ");

int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (max < number2) max = number2;
if (max < number3) max = number3;
    
 Console.WriteLine($"max = {max}");

