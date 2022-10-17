/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i;
        int[] a = new int[8];
        Console.WriteLine("Введите массив чисел: ");
        for (i = 0; i < 8; i++)
       {
            a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введитеследующее число массивасел: ");
        }
        void Met()
        {
            int[] b = a;
            int start = 0, end = 5;
            var segment = new ArraySegment<int>(b, start, end);
            Console.WriteLine(String.Join(", ", segment));
        }
        void Met2()
        {
            int[] c = a;
            int start = 5, end = 6;
            var segment = new ArraySegment<int>(c, start, end);
            Console.WriteLine(String.Join(", ", segment));
        }
        Met();
        Met2();
        
        
    }
}
