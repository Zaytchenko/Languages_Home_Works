// принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

Console.Clear();

int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}

int x1 = DataEntryXY("Введите координату x1: ");
int y1 = DataEntryXY("Введите координату y1: ");
int z1 = DataEntryXY("Введите координату z1: ");
int x2 = DataEntryXY("Введите координату x2: ");
int y2 = DataEntryXY("Введите координату y2: ");
int z2 = DataEntryXY("Введите координату z2: ");

double distance = CalcDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками = " + distance);