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
            Ex3b();     // Naming!
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
            var avg = arr.Average();
            return Math.Sqrt(arr.Average(v => Math.Pow(v - avg, 2)));
        }

        public static void Ex1()
        {
            Console.WriteLine("Enter the size of array");
            var N = Convert.ToInt32(Console.ReadLine());

            var arr = new int[N];

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
            int rA = array1.GetLength(0);
            int cA = array1.GetLength(1);
            int rB = array2.GetLength(0);
            int cB = array2.GetLength(1);
            int temp = 0;
            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += array1[i, k] * array2[k, j];
                    }
                    array3[i, j] = temp;
                }
            }

        }

        public static void Ex5()
        {
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rA = array1.GetLength(0);
            int cA = array1.GetLength(1);
            int rB = array2.GetLength(0);
            int cB = array2.GetLength(1);

            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    array2[j, i] = array1[i, j];
                }
            }
        }

        public static void Ex6()
        {
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int det = 0;
            for (int i = 0; i < 3; i++)
                det = det + (array1[0, i] * (array1[1, (i + 1) % 3] * array1[2, (i + 2) % 3] - array1[1, (i + 2) % 3] * array1[2, (i + 1) % 3]));
            Console.WriteLine(det);
        }

        public static void Ex1b()
        {
            var str = Convert.ToString(Console.Read());
            Console.WriteLine(str.Count(Char.IsWhiteSpace));
        }

        public static void Ex2b()
        {
            var i1 = 5;
            var i2 = 6;
            var temp = i1;
            i1 = i2;
            i2 = temp;
        }

        public static void Ex3b()
        {
            var str = Convert.ToInt32(Console.Read());
            Console.WriteLine(IsPrime(str));
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void Ex4b()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }

        public static void Ex5b()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }










    }
}
