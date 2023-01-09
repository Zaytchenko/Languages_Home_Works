// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    else if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    else return numberN + 1;
}

int numberM = AddNumber("Enter a number M ");
int numberN = AddNumber("Enter a number N ");
AckermanFunction(numberM, numberN);
System.Console.WriteLine("AckermanFunction(m, n) = " + AckermanFunction(numberM, numberN));