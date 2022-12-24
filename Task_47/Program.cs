// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
Console.WriteLine();

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble()*20-10, 1);
        }
    }
    return array;
}

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//получить от пользователя M и N
int m = DataEntry("Введите M: ");
int n = DataEntry("Введите N: ");
//создаем и заполняем двумерный массив
double[,] matrix = CreateRandomArray(m, n, -10, 10);
//вывести на экран
PrintArray(matrix);