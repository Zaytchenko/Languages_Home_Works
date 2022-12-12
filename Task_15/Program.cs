// принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите день недели: ");

int day = int.Parse(Console.ReadLine());
if (day < 1  || day > 7)
{
    Console.WriteLine($"{day} -> ошибка");
}
else

if (day == 6 || day == 7)
{
    Console.WriteLine($"{day} -> выходной");
}
else
Console.WriteLine($"{day} -> рабочий день");

    // If (day == 1 || day == 7)
    // {
    //     Console.WriteLine($"{day} -> такого дня недели не существует");
    // } 
    // else
    // Console.WriteLine($"{day} -> ok");
