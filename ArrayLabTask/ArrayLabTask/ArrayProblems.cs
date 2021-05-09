using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLabTask
{
    class ArrayProblems
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array1 = new int[] { 1,2,3,4,5,6 };


            //reversing 
            for (int i = array1.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array1[i] + "\n");
            } 

            //sum of array elements
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine("Sum of elements: {0}" , sum );

            //copying array elements
            int[] array2 = array1;

            Console.WriteLine(" Copied values of array array1 : \n");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i] + "\n");                
            }

            //duplication finding
            int[] array3 = new int[]{ 1, 1, 1, 2, 2, 3, 4, 5, 6, 6 };

            int x = 0;
            for (int i = 1; i < array3.Length; i++)
            {
                try
                {
                    if (i < array3.Length && array3[i - 1] == array3[i])
                     {
                        x++;
                     }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!" + e);
                }
            }

           Console.WriteLine("Number of duplicates : " + x + "  Pairs");

           //unique findings
           int y = 0;
           for (int i = 1; i < array3.Length; i++)
           {
               try
               {
                   if (i < array3.Length && array3[i - 1] != array3[i])
                   {
                       if (i < array3.Length && array3[i] != array3[i+1])
                       {
                           y = array3[i];
                           Console.WriteLine("Unique Number : {0}", y);
                       }
                   }

               }
               catch (Exception e)
               {
                   Console.WriteLine("Error!" + e);
               }
           }

            Console.ReadKey();    
        }
    }
}
