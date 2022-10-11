/* 
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число: ");
      int num = Convert.ToInt32(Console.ReadLine());
      for  (int i = 0; i<= num; i++)
      {
        Console.Write($"{i*i*i} ");
      }
       
    }
}