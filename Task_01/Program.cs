// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число для сравнения: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число для сравнения: ");

int number2 = int.Parse(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"max = {number1}");
else
Console.WriteLine($"max = {number2}");