/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите 3 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int maxnnum = num1;
if (num2 > maxnnum)
    maxnnum = num2;
if (num3 > maxnnum)
    maxnnum = num3;    
Console.WriteLine(maxnnum);


