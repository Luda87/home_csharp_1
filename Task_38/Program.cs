/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/



double [] FillArray(int size)
{
    double [] array1 = new double [size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(50);
            }
    return  array1;

}

void PrintArray(double [] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void MaxMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> max) max= array [i];
        if (array[i]< min) min= array [i];
    }
    System.Console.WriteLine($"максимальный элемент массива = {max}");
    System.Console.WriteLine($"минимальный элемент массива = {min}");
    System.Console.WriteLine($"разница между максимальным и минимальным элементом массива = {max - min}");

}


System.Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(size);
PrintArray(array);
MaxMin(array);
