/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число: ");
int NumberOfPalindrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Является ли число {NumberOfPalindrom} - палиндромом?");
if (NumberOfPalindrom == Palindrom(NumberOfPalindrom))
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{NumberOfPalindrom} - > да");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"{NumberOfPalindrom} - > нет");
}
Console.ResetColor();

int Palindrom(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result * 10 + number % 10;
        number /= 10;
    }
    return result;
}