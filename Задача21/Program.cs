//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = ReadInt("Введите X точки А: ");
int y1 = ReadInt("Введите Y точки А: ");
int z1 = ReadInt("Введите Z точки А: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int lenghtX = x2 - x1;
int lenghtY = y2 - y1;
int lenghtZ = z2 - z1;
double distance = Math.Sqrt(lenghtX * lenghtX + lenghtY * lenghtY + lenghtZ * lenghtZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}