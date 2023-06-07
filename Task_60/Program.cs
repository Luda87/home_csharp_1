/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int [,,] CreateRandom3DArray()

{

Console.Write("Input qty of rows: ");

int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input qty of columns: " );

int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input array dept: " );

int dept = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[rows, columns, dept];

for(int i = 0; i<rows; i++)

for(int j =0; j < columns; j++)

for(int k =0; k < dept; k++)

array3D[i,j,k] = new Random().Next(10,99);

return array3D;

}

void Show3DArray(int[,,] array3D)

{

for (int i = 0; i < array3D.GetLength(0); i++)

{

for (int j = 0; j < array3D.GetLength(1); j++)

{

Console.WriteLine();

for (int k = 0; k < array3D.GetLength(2); k++)

{

Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");

}

}

}

}

int[,,] myArray = CreateRandom3DArray();

Show3DArray(myArray);