/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

decimal Degree (decimal A, int B)
{
    decimal res = 1;
    for(int i=1; i<= B; i++)
    {
        res= res*A;
    }
    return res;
}


 Console.WriteLine("Введите число A");
 decimal A = Convert.ToDecimal(Console.ReadLine());
 Console.WriteLine("Введите число B");
 int B = Convert.ToInt32(Console.ReadLine());

decimal result = Degree(A, B);
 System.Console.WriteLine($"{A} в степени {B}  = {result}");