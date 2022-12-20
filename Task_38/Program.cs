// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
Console.Clear();

const int SIZE = 6;
const int LEFT_RANGE = -100;
const int RIGHT_RANGE = 100;

double[] array = new double[SIZE];

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1) + rand.NextDouble(); //[-100;100]
    }
    return arr;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');

double max = Math.Round(array[0], 2);
double min = Math.Round(array[0], 2);

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = Math.Round(array[i], 2);
    }
    if (array[i] < min)
    {
        min = Math.Round(array[i], 2);
    }
}
System.Console.WriteLine("max= " + max);
System.Console.WriteLine("min= " + min);
double difference = Math.Round(max, 2) - Math.Round(min, 2);
System.Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);