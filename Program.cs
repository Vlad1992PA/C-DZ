/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("ведите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int delitel = num % 2;
        int zero = 0;

        if (delitel == zero)
        {
            Console.WriteLine("Число: " + num + " четное");
        }
        else
        {
            Console.WriteLine("Число: " + num + " не четное");
        }
    }
}