/*
Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
и возвращает позицию этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-1, 1);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

string ElementArray(int[,] array, int number)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                res = ($"Позиция элемента {number}  = [{i},{j}]");
                break;
            }

        }

    }
if (res.Length == 0) res =  $"{number} такого числа в массиве нет";
 return res;

}



Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);
ElementArray(array, num);
System.Console.WriteLine(ElementArray(array, num));