//  выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите число N ");

int N = int.Parse(Console.ReadLine());

if (N < 100)
{
    Console.WriteLine("Третьей цифры в этом числе нет");
}
else
{
    while (N > 999)
    {
        N = N / 10;
    }
    N = N % 10;
    
    Console.WriteLine(N);
}