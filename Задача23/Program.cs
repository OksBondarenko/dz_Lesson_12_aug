//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//int number = ReadInt("Введите число: ");

void Cub(int num)
{
    for(int i = 1; i < num; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(num, 3));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Cub(ReadInt("Введите число: "));

