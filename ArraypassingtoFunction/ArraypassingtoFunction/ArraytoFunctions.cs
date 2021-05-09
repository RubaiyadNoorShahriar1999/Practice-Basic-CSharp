using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraypassingtoFunction
{
    class ArraytoFunctions
    {

        //1D Array printing
        static void ArrayPrinting1D(int[] arr)
        {
            Console.WriteLine("By basic for loop");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("By foreach loop");
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine();
        }


        //2D array printing
        static void ArrayPrinting2D(int[,] arr)
        {
            int row = arr.GetLength(0); //Getting the row and column using GetLength property
            int col = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
                
            }
        }


        //Jagged array printing 
        static void ArrayPrintingJagged(int[][] arr)
        {
            Console.WriteLine("Using basic for loop");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            Console.WriteLine("Using foreach loop");
            foreach (int[] innerArray in arr)  //Here innerarray is taking the arrays inside arr one by  
            {                                  //one anfd keeing it in innerarray
                foreach (int indended in innerArray)//ex: int[] innerarray = arr[0];
                {
                    Console.Write(indended + " ");//Here indended is taking each element at a time from innerarray
                }                                 //ex: indended= innerarray[0];
                Console.WriteLine();
                
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[] { 20, 30, 40 };
            int[,] array2 = new int[,]{
                {10, 20 ,30},
                {11, 22 ,33},
                {100, 200 ,300}
            };
            int[][] array3 = new int[][]{
                new int[] {2,4,6},
                new int[] {1,3,5,7,9}
            };

            //calling (Passing the array as a parameter)
            ArrayPrinting1D(array1);
            Console.WriteLine("\n");

            ArrayPrinting2D(array2);
            Console.WriteLine("\n");

            ArrayPrintingJagged(array3);


            Console.ReadKey();
        }
    }
}
