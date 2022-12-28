// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

void ProductTwoArrays(int[,] matrix1, int[,] matrix2)
{
    int[,] prodMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
                prodMatrix[i,j] = sum;
            }
        }
    }
    System.Console.WriteLine("Result Dimension");
    PrintArray(prodMatrix);
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
//creating and filling a two-dimensional arrays
int[,] matrix1 = CreateRandomArray(m, n, 1, 10);
int[,] matrix2 = CreateRandomArray(m, n, 1, 10);
// output to the screen
System.Console.WriteLine("Dimension 1");
PrintArray(matrix1);
System.Console.WriteLine("Dimension 2");
PrintArray(matrix2);
// Massives product and print to the screen
ProductTwoArrays(matrix1, matrix2);