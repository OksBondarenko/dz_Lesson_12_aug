//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

bool Palindrome(int num)
{
    int a = num / 10000;
    int b = num % 10;
    bool result = false;

    if (a == b)
    {
        a = num / 1000 % 10;
        b = num / 10 % 10;
        if (a == b)
        {
            result = true;
        }
    }
    return result;

} 

int number = ReadInt("Введите пятизначное число: ");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write(Palindrome(number));