using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(0);
            //Console.WriteLine("Set array`s size: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(10);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + "\t");
            //}
            //Console.WriteLine();

            //foreach (int i in arr)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();

            //// 2d arrays

            //int rows, cols;
            //Console.WriteLine("enter number of Rows: "); rows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter number of Cols: "); cols = Convert.ToInt32(Console.ReadLine());

            //int[,] i_arr_2 = new int[rows, cols];
            //Console.WriteLine($"Number of demensions: {i_arr_2.Rank}");
            //for (int i = 0; i < i_arr_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < i_arr_2.GetLength(1); j++)
            //    {
            //        i_arr_2[i, j] = random.Next(0, 200);
            //        Console.Write(i_arr_2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //foreach (int i in i_arr_2)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();

            //jagged arrays

            int row = 5;
            int[][] i_arr_j = new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6, 7, 8 },
                    new int[] { 9, 10, 11, 12, 13, 14, 15, 16 },
                    new int[] { 17, 18, 19, 20, 21, 22 }
                };
            for (int i = 0; i < i_arr_j.Length; i++)
            {
                for (int j = 0; j < i_arr_j[i].Length; j++)
                {
                    Console.Write(i_arr_j[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
