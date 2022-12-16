// задает массив из 8 элементов и выводит их на экран

Console.Clear();

Console.Clear();

void FillArray(int[] array)
{
    int number = array.Length;
    for ( int i = 0; i < number; i++)
    {
     array[i] = new Random().Next(100);   
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write(col[j] + ", ");
    }
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);

