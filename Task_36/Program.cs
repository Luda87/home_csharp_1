/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(50);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


int SumEvenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum+= array[i];
    }
    return sum;
}

int[] Myarray = new int[7];
FillArray(Myarray);
PrintArray(Myarray);
int result = SumEvenPosition(Myarray);
System.Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях = {result}");

