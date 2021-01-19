using System;

namespace Lab11_18_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineTest();
        }

        public static void DvDTest()
        {
            var dvd = new DvDPlayer();
            dvd.CurrentDisc = "ThOR 3";
            Console.WriteLine(dvd.CurrentDisc);
        }

        public static void ConverterTest()
        {
            int num1 = 54;
            double num2 = 34.44;
            float num3 = 13.37f;

            ConverterCentemeterToMeter.Convert(num1);
            ConverterCentemeterToMeter.Convert(num2);
            ConverterCentemeterToMeter.Convert(num3);
        }

        public static void EngineTest()
        {
            var supEng = new SuperEngine();
            supEng.Engine(54.0, 999, 8);
            var eng1 = new Engine1();
            eng1.Engine(54.0, 999, 8);
        }

        class DvDPlayer
        {
            private string _currentdisc;
            public string CurrentDisc
            {
                get
                {
                    return $"The current disc is {_currentdisc}";
                }
                set
                {
                    _currentdisc = value;
                    Console.WriteLine($"The current disc is setted to {value}");
                }
            }

        }

        class ConverterCentemeterToMeter
        {
            public static void Convert(int num)
            {
                Console.WriteLine(num / 100);
            }

            public static void Convert(double num)
            {
                Console.WriteLine(num / 100.0);
            }

            public static void Convert(float num)
            {
                Console.WriteLine(num / 100.0);
            }
        }

        public class SuperEngine
        {
            public virtual void Engine(double power, int rpm, int cylinder)
            {
                Console.WriteLine($"Power is {power}");
            }
        }

        public class Engine1 : SuperEngine
        {
            public override void Engine(double power, int rpm, int cylinder)
            {
                Console.WriteLine($"Assistent \n POWER IS {power} \n RPM IS {rpm} \n NO. OF CYLINDERS IS {cylinder}");
            }
        }



    }
}
