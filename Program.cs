/* 
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите координаты первой точки через , : ");
      string nums = Console.ReadLine();
      string x1 = String.Empty;
      string y1 = String.Empty;
      string z1 = String.Empty;
      char simvol1 = ',';
      int  count = 0;
      for  (int i = 0; i< nums.Length; i++)
      {        
        if (count == 0)
        {
          if (nums[i] != simvol1)
          {
            x1 = x1 + nums[i].ToString();
          }
          else
          {
            count= count +1;            
          }
         
        }
        else if (count == 1)
        {
          if (nums[i] != simvol1)
          {
            y1 = y1 + nums[i].ToString();
          }
          else
          {
            count= count +1;            
          }
         
        }
        else if (count == 2)
        {
          if (nums[i] != simvol1)
          {
            z1 = z1 + nums[i].ToString();
          }
          else
          {
            count= count +1;            
          }
        }
      }
      
      Console.WriteLine("введите координаты второй точки через ,: ");
      string nums2 = Console.ReadLine();
      string x2 = String.Empty;
      string y2 = String.Empty;
      string z2 = String.Empty;
      int  count2 = 0;
      
      for  (int n = 0; n < nums2.Length; n++)
      {
        
        if (count2 == 0)
        {
          if (nums2[n] != simvol1)
          {
            x2 = x2 + nums2[n].ToString();
          }
          else
          {
            count2 += 1;            
          }
         
        }
        else if (count2 == 1)
        {
          if (nums2[n] != simvol1)
          {
            y2 = y2 + nums2[n].ToString();
          }
          else
          {
            count2 += 1;            
          }
         
        }
        else if (count2 == 2)
        {
          if (nums2[n] != simvol1)
          {
            z2 = z2 + nums2[n].ToString();
          }
          else
          {
            count2 += 1;            
          }
        }
      }

      int int_x1 = Convert.ToInt32(x1);
      int int_y1 = Convert.ToInt32(y1);
      int int_z1 = Convert.ToInt32(z1);
      int int_x2 = Convert.ToInt32(x2);
      int int_y2 = Convert.ToInt32(y2);
      int int_z2 = Convert.ToInt32(z2);
      
      double distance = Math.Sqrt((Math.Pow((int_x2-int_x1), 2) + Math.Pow((int_y2-int_y1), 2) + Math.Pow((int_z2-int_z1), 2)));
      Console.WriteLine("ответ: " + distance);       
    }
}