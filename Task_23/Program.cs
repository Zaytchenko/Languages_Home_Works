//принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

void TableOfPow2(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        double pow2 = Math.Pow(count, 3);
        Console.Write(pow2 + " ");
        count++;
    }
    Console.WriteLine();
}
TableOfPow2("Введите число N: ");