/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        
        int Met(string nums)
        {
            int sum = 0;
            for  (int i = 0; i< nums.Length; i++)
            {
                int x = Convert.ToInt32(nums[i].ToString());
                sum = sum + x;
            }
            return sum;
        }
            
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();
            int summa = Met(num);
        
            Console.WriteLine("Hello, world! ^ " + summa);
        
    }
}
