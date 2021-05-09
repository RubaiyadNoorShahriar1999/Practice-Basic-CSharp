using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTasks
{
    class Arrays
    {
        static void Main(string[] args)
        {   
            //Single dimensional array 
            int[] array1 = new int [2];
            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = new int[] { 1, 2, 3 };
            int[] array4 = { 1, 2, 3 };

            //2D Array
            int[,] array5 = new int[2, 3];
            int[,] array6 = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };

            //Jagged array
            int[][] array7 = new int[3][];   //3 is the number of arrays inside array7   //way 1
            array7[0] = new int[3]; //index range 0-2 
            array7[1] = new int[4]; //index range 0-3
            array7[2] = new int[5]; //index range 0-4

            int[][] array8 = {                  //way 2
                                    new int [] { 1 , 2 , 3 },
                                    new int [] { 4 , 5 , 6 , 7 },
                                    new int []  {8 , 9}
                                    
                             };
            //Changing value of a particular index
            array8[1  /*array number*/][2 /*Indedx number of the indended array*/] = 22;


            //showing jagged array in console
            for (int i = 0; i < array8.Length; i++)
            {
                for (int j = 0; j < array8[i].Length; j++)
                {
                    Console.Write(array8[i][j] + " ");
                }
                Console.WriteLine( "\n");
            }


            //showing 1D Array elements
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Elements of Array 2 of  index array2[{0}] = {1}\n" , i , array2[i]);
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("Elements of Array 3 of index array3[{0}] = {1}\n", i, array3[i]);
            }

            for (int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine("Elements of Array 4 of index array4[{0}] = {1}\n" , i , array4[i]); 
            }

            //showing 2D array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array6[i,j] + " "); 
                }
                Console.WriteLine();
            }



            Console.Readkey();

        }
    }
}
