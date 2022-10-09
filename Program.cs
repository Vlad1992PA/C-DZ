/* 
Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

3267912 -> 6
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("ведите тех значное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int digit = 0;
        if (num < 1000 & num > 99)
        {
            digit = num % 10;
            Console.WriteLine(digit);
        }
        else
        {
            Console.WriteLine("третьей цифры нет."); 
        }
         
                
    }
}