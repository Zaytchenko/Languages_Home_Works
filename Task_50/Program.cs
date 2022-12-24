//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию элемента этого  или же указание, что такого элемента нет.
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет

// Задайте двумерный массив размером m x n, заполненный случайными целыми числами

Console.Clear();

void PrintPosition(int[,] array, int number)
{
    bool print = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                System.Console.WriteLine($"Позиция искомого элемента ({i},{j})");
                print = false;
            }
        }
    }
if (print)
{
  System.Console.WriteLine("Искомый элемент не найден");
}
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

//получить от пользователя M и N
int m = DataEntry("Введите M: ");
int n = DataEntry("Введите N: ");
//создаем и заполняем двумерный массив
int[,] matrix = CreateRandomArray(m, n, 1, 10);
//вывести на экран
PrintArray(matrix);
// просим пользователя ввести искомое число
int number = DataEntry("Введите искомое число: ");
//вызываем метод поиска позиции
PrintPosition(matrix, number);