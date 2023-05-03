/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
int result;
Console.Write($"{Number} -> ");
for (int i = 1; i <= Number; i++)
{
    result = i * i * i;
    Console.Write (result);
    if (i != Number)
    {
        Console.Write(" , ");
    }
}
