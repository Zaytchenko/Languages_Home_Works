// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                System.Console.Write($" 0{array[i, j]} ");
            }
            else
                System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int n = 4;
int[,] arr = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while (value <= n * n)
{
    arr[i, j] = value;
    value++;
    if (i <= j + 1 && i + j < n - 1) j++;
    else if (i < j && i + j >= n - 1) i++;
    else if (i >= j && i + j > n - 1) j--;
    else  i--;
}
PrintArray(arr);