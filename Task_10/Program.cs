//  принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();

Console.WriteLine("Введите трехзначное число");

int result = int.Parse(Console.ReadLine());

result = ((result / 10)  % 10);
Console.Write($" -> {result}");