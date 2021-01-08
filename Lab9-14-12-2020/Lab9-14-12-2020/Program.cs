using System;
using System.Runtime.InteropServices;

namespace Lab9_14_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            OddTest();
        }

        public static void CubeTest()
        {
            var test = new Cube(8);
        }
        public static void PyramidTest()
        {
            var test = new Pyramid();
        }

        public static void SumApTest()
        {
            var SumAp = new SumAp(2, 2, 5);
        }
        public static void ConverterTest()
        {
            var test = new Converter(8);
        }

        public static void FloydTest()
        {
            var Floyd = new Floyd(10);
        }

        public static void OddTest()
        {
            var Odd = new OddNumber(30);
        }

        class Base
        {
            public void GetWowString()
            {
                Console.WriteLine("WOOOOOOOOOOOOOOOOOOW!");
            }
        }

        class SuperBase : Base
        {
            public void GetSuperWowString()
            {
                GetWowString();
                Console.WriteLine("SUUPERRRRRRRMULTI!");
            }
        }
        class Cube : Base
        {
            public Cube(int _num)
            {
                Console.WriteLine(_num * _num * _num);
                GetWowString();
            }
        }

        class Pyramid : SuperBase
        {
            public Pyramid()
            {
                var height = 10;

                for (int i = height - 1; i >= 0; --i)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < (height - i) * 2 - 1; ++j)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                GetSuperWowString();
            }
        }

        class SumAp : SuperBase
        {
            public SumAp(int first, int differ, int n)
            {
                GetSuperWowString();
                Console.WriteLine($"Sum is {(2 * first + differ * (n - 1)) * n / 2}");
            }
        }

        class Converter : SuperBase
        {
            public Converter(int _decimal)
            {
                Console.WriteLine(Convert.ToString(_decimal, 2));
                GetSuperWowString();
            }
        }

        class Floyd : SuperBase
        {
            public Floyd(int n)
            {
                // 1
                // 1 2
                // 3 4 5
                var v = 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{v} ");
                        v++;
                    }

                    Console.WriteLine();
                }

                GetSuperWowString();
            }
        }

        class OddNumber : SuperBase
        {
            public OddNumber(int n)
            {
                var sum = 0;
                for (int i = 1; i < n; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"Sum is {sum}");
                GetSuperWowString();
            }
        }
    }
}
