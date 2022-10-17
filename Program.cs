/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        
        int Met(int x, int y)
        {
            int sum = Convert.ToInt32(Math.Pow(x, y));
            return sum;
        }
        
        int a = 1;
        while (a>0)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the degree: ");
            int stepen = Convert.ToInt32(Console.ReadLine());
            int stroka = Met(num1, stepen);
            Console.WriteLine (stroka);
            a=a+1;
        }
        
    }
}
