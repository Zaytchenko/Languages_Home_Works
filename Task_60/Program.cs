// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

void CheckDuplicateOfArray(int[,,] array, int leftRange, int rightRange)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(2); k++)
            {
                int temporary = array[i, j, k-1]; // не могу понять, что положить в temporary
                for (int l = 0; l < i * j * k; l++)
                {
                    if (array[i, j, k] == temporary)
                        array[i, j, k] = new Random().Next(leftRange, rightRange);
                }
            }
        }
    }
    System.Console.WriteLine();
    PrintArray(array);
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($" {array[i, j, k]} ({i}, {j}, {k})");
            }
        }
        System.Console.WriteLine();
    }
}


int[,,] CreateRandomArray(int rows1, int rows2, int columns, int leftRange, int rightRange)
{
    int[,,] array = new int[rows1, rows2, columns];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < rows2; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rightRange);
            }
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

// get from the user L, M, N
int l = DataEntry("Enter L - number of rows: ");
int m = DataEntry("Enter M - number of rows: ");
int n = DataEntry("Enter N- number of columns: ");
//creating and filling a threе-dimensional array
int[,,] matrix = CreateRandomArray(l, m, n, 1, 100);
// output to the screen
CheckDuplicateOfArray(matrix, 1, 100);