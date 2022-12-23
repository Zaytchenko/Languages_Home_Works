// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
Console.Clear();

int DataEntry(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = DataEntry("Введите кол-во проверяемых чисел: ");
int[] array = new int[m];
int count = 0;

for (int i = 0; i < m; i++)
{
    array[i] = DataEntry("Введите число: ");
    if (array[i] > 0)
    {
        count += 1 ;
    }
}
System.Console.WriteLine("среди чисел " + string.Join(", ", array));
System.Console.WriteLine(count + " чисел > 0");