internal class Program
{
    private static void Main(string[] args)
    {
        /* задача C# №2
        Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        2, 3, 7 -> 7
        44 5 78 -> 78
        22 3 9 -> 22*/
   
        Console.Write("ведите first число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ведите second число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ведите the third число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = 0;
      
        if (num1 > num2)
        {
           if (num1 > num3) 
           {
            max = num1;
           }

           else
           {
            max = num3;
           }
        }

        else if (num2 > num3)
        {
            max = num2; 
        }

        else
        {
            max = num3;
        }
            
        Console.WriteLine("max = " + max);        
    }
}
