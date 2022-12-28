// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
Console.WriteLine();

void SumOfArrayRowNumbers(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            arr[i] = sum;
        }
    }
    Console.WriteLine('[' + string.Join(", ", arr) + ']');
    int minPosition = 0;
    int min = arr[0];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (arr[i]< min)
        {
         min = arr[i];
         minPosition = i;
        }
    }
    System.Console.WriteLine("Summ minimum (" + min + ") in "  + (minPosition + 1) + " row");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
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

// get from the user M and N
int m = DataEntry("Enter M - number of rows: ");
int n = DataEntry("Enter N- number of columns: ");
//creating and filling a two-dimensional array
int[,] matrix = CreateRandomArray(m, n, 1, 10);
//output to the screen
PrintArray(matrix);
SumOfArrayRowNumbers(matrix);