using System;

namespace lab_8_07_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Test(20);
            Console.WriteLine();
            var test2 = new Test();
            Console.WriteLine();
            // 2 + 4 + 6 + 8 + 10 = 30
            var SumAp = new SumAp(2, 2, 5);
            Console.WriteLine();
            var Floyd = new Floyd(10);
        }

        class SumAp
        {
            public SumAp(int first, int differ, int n) => Console.WriteLine($"Sum is {(2 * first + differ * (n - 1)) * n / 2}");
        }



        class Floyd
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
            }
        }


        class Test
        {

            public Test(int n)
            {
                var sum = 0;
                for (int i = 1; i < n; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"Sum is {sum}");
            }

            public Test()
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
            }


        }
    }
}
