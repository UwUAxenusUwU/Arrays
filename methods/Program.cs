using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int length = args.Length;
            //int[] arr = new int[] { };
            //foreach (string i in args)
            //{
            //    Console.WriteLine(i+'\t');
            //}

            //List<int> l_numbers = new List<int>();
            //foreach (string i in args) { l_numbers.Add(Convert.ToInt32(i)); }
            //Console.WriteLine(Sum(l_numbers.ToArray()));

            int a, b;
            Input(out a, out b);
            Console.WriteLine($"{a} {b}");
            Exchenge(ref a,ref b);
            Console.WriteLine($"{a} {b}");
        }
        static void Input(out int a,out int b)
        {
            Console.WriteLine("Set A value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Set B value: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void Exchenge(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
        }
        static int Sum (params int[] numbers) 
        {
            int sum = 0;
            foreach (int i in numbers) sum += i;
            return sum; 
        }
    }
}
