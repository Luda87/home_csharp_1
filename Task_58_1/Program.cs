/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



int [,] CreateRandomFirst2DMatrix(int firstrows,int firstcolumns)
{
int[,] array = new int[firstrows, firstcolumns];
for(int i = 0; i<firstrows; i++)
for(int j =0; j < firstcolumns; j++)
array[i,j] = new Random().Next(1,9);
return array;
}
int [,] CreateRandomSecond2DMatrix(int secondrows,int secondcolumns)
{
int[,] array = new int[secondrows, secondcolumns];
for(int i = 0; i<secondrows; i++)
for(int j =0; j < secondcolumns; j++)
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
Console.Write("Input qty of rows for first matrix: ");
int firstrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qty of columns for second matrix: " );
int firstcolumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qty of rows for second matrix: ");
int secondrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qty of columns for second matrix: " );
int secondcolumns = Convert.ToInt32(Console.ReadLine());
int[,] newFirstMatrix = CreateRandomFirst2DMatrix(firstrows,firstcolumns);
int[,] newSecondMatrix = CreateRandomSecond2DMatrix(secondrows,secondcolumns);

Show2DArray(newFirstMatrix);
Show2DArray(newSecondMatrix);

int[,] TwoMatrixMultiplication = new int[firstrows,secondcolumns];
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

