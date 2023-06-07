/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



int [,] CreateRandomFirst2DMatrix(int firstRows,int firstColumn)
{
int[,] array = new int[firstRows, firstColumn];
for(int i = 0; i<firstRows; i++)
for(int j =0; j < firstColumn; j++)
array[i,j] = new Random().Next(1,9);
return array;
}
int [,] CreateRandomSecond2DMatrix(int secondRows,int secondColumn)
{
int[,] array = new int[secondRows, secondColumn];
for(int i = 0; i<secondRows; i++)
for(int j =0; j < secondColumn; j++)
array[i,j] = new Random().Next(1,9);
return array;
}
void Show2DArray(int[,] array)
{
for(int i =0; i<array.GetLength(0); i++)
{
for(int j =0; j<array.GetLength(0); j++)
Console.Write(array[i,j] + " ");
Console.WriteLine();
}
Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int firstColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int secondColumn = Convert.ToInt32(Console.ReadLine());

int[,] newFirstMatrix = CreateRandomFirst2DMatrix(firstRows,firstColumn);
int[,] newSecondMatrix = CreateRandomSecond2DMatrix(secondRows,secondColumn);

Show2DArray(newFirstMatrix);
Show2DArray(newSecondMatrix);

int[,] TwoMatrixMultiplication = new int[firstRows,secondColumn];
if (newFirstMatrix.GetLength(0) != newSecondMatrix.GetLength(1))
{
Console.WriteLine(" Матрицы не одинакового размера,перемножить их невозможно ");
return;
}
for (int i = 0; i < newFirstMatrix.GetLength(0); i++)
{
for (int j = 0; j < newSecondMatrix.GetLength(1); j++)
{
TwoMatrixMultiplication[i, j] = 0;
for (int k = 0; k < newFirstMatrix.GetLength(1); k++)
{
TwoMatrixMultiplication[i, j] += newFirstMatrix[i, k] * newSecondMatrix[k, j];
}
}
}
Show2DArray(TwoMatrixMultiplication);
