/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


 int HowManyPosNumbersInArray(int[]array) 
{ 
     int count = 0; 
     for (int i = 0; i < array.Length; i++) 
     
         if (array[i] > 0) count++; 
     return count; 
 } 
 
 System.Console.WriteLine("Enter elements of array with gaps:"); 
 int[] NewArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
 

 System.Console.WriteLine($"There are {HowManyPosNumbersInArray(NewArray)} positive numbers in this array."); 