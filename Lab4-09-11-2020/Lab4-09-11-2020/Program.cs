using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Lab4_09_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex3();
        }

        public static double Median(int[] arr)
        {
            Array.Sort(arr);

            if (arr.Length % 2 == 0)
            {
                return (arr[ (arr.Length / 2) - 1] + arr[(arr.Length / 2)]) / 2.0;
            }
            else
            {
                return arr[arr.Length / 2];
            }
        }

        public static int Mode(int[] arr)
        {
            return  arr.GroupBy(v => v)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
        }

        public static double StdDev(int[] arr)
        {
            double avg = arr.Average();
            return Math.Sqrt(arr.Average(v => Math.Pow(v - avg, 2)));
        }

        public static void Ex1()
        {
            Console.WriteLine("Enter the size of array");
            var N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            Console.WriteLine($"Mean is {arr.Average()}, median is { Median(arr)}, mode is { Mode(arr)}, stdDev is { StdDev(arr)}");

        }

        public static void Ex2()
        {
            Console.WriteLine("Enter the size of array");
            var N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }



        }

        public static void Ex3()
        {
            Console.WriteLine("Enter the size of array");
            var N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var dict = new Dictionary<int,int>();

            foreach (int a in arr)
            {
                if (dict.ContainsKey(a))
                    dict[a] = dict[a] + 1; 
                else
                    dict[a] = 1;
            }

            foreach (KeyValuePair<int, int> kvp in dict)
            {

                if (kvp.Value > 1)
                {
                    Console.WriteLine($"Duplicate of {kvp.Key}, {kvp.Value} times");   
                }

            }

            //dict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);


        }

        public static void Ex4()
        {
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array3 = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                }
            }

        }



    }
}
