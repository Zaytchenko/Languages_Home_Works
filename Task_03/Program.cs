// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)
Console.Clear();

Console.Write("Введите число: ");

int number1 = int.Parse(Console.ReadLine());

bool number2 = false;

if (number1 %2 == 0) number2 = true;

 Console.WriteLine("Проверка на четность: {0}", number2);
