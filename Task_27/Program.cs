// Принимает на вход число и выдает сумму цифр в числе
Console.Clear();

void SumNumbers(string strg)
{
    Console.WriteLine(strg);
    string str = Console.ReadLine();
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
        if ((str[i] >= '0') && (str[i] <= '9'))
        {
            sum += str[i] - '0';
        }
    Console.Write("Сумма элементов равна " + sum);
}

SumNumbers("Введите число ");