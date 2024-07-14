using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose array type: \n1 - 1d array\n2 - 2d array\n3 - jagged array: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            int Sum = 0, Avg = 0, min = 0, max = 0;
            Random rnd = new Random();
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Set array length");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rnd.Next(0, 300);
                        Console.Write(arr[i] + "\t");
                    }
                    min = arr[0];
                    foreach (int i in arr)
                    {
                        Sum += i;
                        if (min > i)
                        { min = i; }
                        if (max < i)
                        { max = i; }
                    }
                    Avg = Sum / n;
                    Console.WriteLine();
                    Console.WriteLine($"Summ = {Sum}; Average = {Avg}; Min = {min}; Max = {max}");
                    Console.WriteLine();
                    break;
                case 2:
                    int Rows, Cols;
                    Console.WriteLine("Set array Rows: ");
                    Rows = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Set array Cols: ");
                    Cols = Convert.ToInt32(Console.ReadLine());
                    int[,] arr_2d = new int[Rows, Cols];
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Cols; j++)
                        {
                            arr_2d[i, j] = rnd.Next(0, 300);
                            Console.Write(arr_2d[i, j] + "\t");
                            Sum += arr_2d[i, j];
                        }
                        Console.WriteLine();
                    }
                    foreach (int i in arr_2d)
                    {
                        if (min > i)
                        { min = i; }
                        if (max < i)
                        { max = i; }
                    }
                    Avg = Sum / (Rows * Cols);
                    Console.WriteLine();
                    Console.WriteLine($"Summ = {Sum}; Average = {Avg}; Min = {min}; Max = {max}");
                    Console.WriteLine();
                    break;
                case 3:
                    int Rows_jag;
                    int elements = 0;
                    Console.WriteLine("Set jagged array Rows: ");
                    Rows_jag = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    int[][] arr_jag = new int[Rows_jag][];
                    for (int i = 0; i < Rows_jag; i++)
                        {
                            int size = rnd.Next(1,10);
                            arr_jag[i] = new int[size];
                        }
                    for (int i = 0; i < Rows_jag; i++)
                    {
                        for (int j = 0; j < arr_jag[i].Length; j++)
                        {
                            arr_jag[i][j] = rnd.Next(0,300);
                            Console.Write(arr_jag[i][j] + "\t");
                            elements++;
                            Sum += arr_jag[i][j];
                        }
                        Console.WriteLine();
                    }
                    min = arr_jag[0][0];
                    for (int i = 0; i < Rows_jag; i++)
                    {
                        for (int j = 0; j < arr_jag[i].Length; j++)
                        {
                            if (min > arr_jag[i][j])
                            { min = arr_jag[i][j]; }
                            if (max < arr_jag[i][j])
                            { max = arr_jag[i][j]; }
                        }
                    }
                    Avg = Sum / elements;
                    Console.WriteLine();
                    Console.WriteLine($"Summ = {Sum}; Average = {Avg}; Min = {min}; Max = {max}");
                    Console.WriteLine();
                    break;
                //case 4:
                //    Console.WriteLine("Set size of array: ");
                //    int size_arr = Convert.ToInt32(Console.ReadLine());
                //    int[] rnd_arr = new int[size_arr];
                //    for (int i = 0; i < size_arr; i++)
                //    {
                //        rnd_arr[i] = rnd.Next(0, 3);
                //        Console.Write(rnd_arr[i] + "\t");
                //    }
                //    Console.WriteLine();
                //    int number = 0;
                //    for (int i = 0; i < size_arr; i++)
                //    {
                //        bool same = false;
                //        int buf = rnd_arr[i];
                //        Array.Sort(rnd_arr);
                //        if ()
                //        {
                //            for (int j = 0; j < size_arr; j++)
                //            {
                //                if (rnd_arr[j] == buf) { same = true; number++; }
                //            }
                //        }
                //        if (same) Console.WriteLine($"Same value = {buf}, and it meets for {number} times;");
                //    }
                //    break;
                //пока не сообразил, как доработать, отложу на потом
            }

        }
    }
}
