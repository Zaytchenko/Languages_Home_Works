// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double DataEntry(string str)
{
    System.Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double k1 = DataEntry("Введите k1");
double b1 = DataEntry("Введите b1");
double k2 = DataEntry("Введите k2");
double b2 = DataEntry("Введите b2");

double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
double y = Math.Round((k1 * x + b1), 2);
System.Console.WriteLine("(" + x + ";" + y + ")");