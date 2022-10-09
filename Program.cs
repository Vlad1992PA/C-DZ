/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("ведите число дня недели от 1 до 7: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if (num == 6)
        {
            Console.WriteLine("Это выходной день");
        }

        else if (num == 7)
        {
            Console.WriteLine("Это выходной день");
        }

        else
        {
            Console.WriteLine("Это не выходной день");
        }       
    }
}