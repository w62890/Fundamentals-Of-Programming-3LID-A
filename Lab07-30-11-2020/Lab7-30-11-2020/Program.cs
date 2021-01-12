using System;

namespace Lab7_30_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseTest();
        }

        public static void ConverterTest()
        {
            var test = new Converter(8);
        }

        public static void CubeTest()
        {
            var test = new Cube(8);
        }

        public static void DiamondTest()
        {
            var test = new Diamond(8);
        }

        public static void ReverseTest()
        {
            var test = new Reverse(12345);
        }
        class Converter
        {
            public Converter(int _decimal)
            {
                Console.WriteLine(Convert.ToString(_decimal, 2));
            }
        }

        class Cube
        {
            public Cube(int _num)
            {
                Console.WriteLine(_num * _num * _num);
            }
        }

        class Diamond
        {
            public Diamond(int r)
            {
                int i, j;
                for (i = 0; i <= r; i++)
                {
                    for (j = 1; j <= r - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                for (i = r - 1; i >= 1; i--)
                {
                    for (j = 1; j <= r - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }

        }

        class Reverse
        {
            public Reverse(int n)
            {
                int rev = 0;
                while (n != 0)
                {
                    var remainder = n % 10;
                    rev = rev * 10 + remainder;
                    n /= 10;
                }

                Console.WriteLine(rev);
            }
        }


    }
}
