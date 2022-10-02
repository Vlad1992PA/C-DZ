/* 
Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("ведите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int delitel = 2;
        int zero = 0;
        int count = 1;
        string nums = "";

        while (count <= num)
        {
            if (count % delitel == zero)
            {
                nums = nums + (Convert.ToString(count) + ", ");
                count ++;
            }
            else
            {
                count ++;
            }
            Console.
        }
    }
}