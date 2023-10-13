//Задача 21: Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int x2 = ReadInt("Введите координату Z первой точки: ");
int y2 = ReadInt("Введите координату X второй точки: ");
int x3 = ReadInt("Введите координату Y второй точки: ");
int y3 = ReadInt("Введите координату Z второй точки: ");


double length = Math.Sqrt((y1 - x1)*(y1 - x1) + (y2 - x2) * (y2 - x2) + (y3 - x3) * (y3 - x3));
Console.WriteLine($"Длинна отрезка {length}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
