using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;

namespace Lab6_23_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountTest();
        }

        static void HumanTest()
        {
            var human = new Human();
            human.Age = Int32.MaxValue;
            Console.WriteLine(human.Age);
        }

        static void TriaTest()
        {
            var triangle = new Triangle(14, 10);
            Console.WriteLine(triangle.AreaOfTriangel());
        }

        static void StudentTest()
        {
            var student = new Student();
            student.Name = "Sunil";
            student.StudentId = "w123456";
            student.Marks = new List<int>() { 3, 4, 3, 5 };
            Console.WriteLine(student.Final);
        }

        static void InchTest()
        {
            var twoDistances = new TwoDistances();
            twoDistances.Inches = 12;
            twoDistances.Feet = 1;
            Console.WriteLine(twoDistances.SumInInch);
        }

        static void DateTest()
        {
            var dateTest = new TwoTimes();
        }

        static void SecondsTest()
        {
            var secondTest = new SecondsToTime(4060);
        }

        static void TimeToSecondsTest()
        {
            var test = new TimeToSeconds(1,7,40);
        }

        static void ElectionTest()
        {
            var test = new Election();
            test.Candidates = new Dictionary<string, int>
            {
                {"Krax",500},
                {"Trump", 1500},
            };
            test.GetWinner();
        }

        static void AccountTest()
        {
            var account = new Account("Sunil", 1000);
            account.WithDraw(1000);
            account.Deposit(2000);
            Console.WriteLine(account.Personal);
        }
    }

    class Human
    {
        public int Age;
    }

    class Triangle
    {
        private double _baseOfTriangle;
        private double _heightOfTriangle;

        public Triangle(double baseOfTriangle, double heightOfTriangle)
        {
            _baseOfTriangle = baseOfTriangle;
            _heightOfTriangle = heightOfTriangle;
        }

        public double AreaOfTriangel() => 0.5 * _baseOfTriangle * _heightOfTriangle;


    }

    class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public List<Int32> Marks { get; set; }
        public double Final => Marks.Average();
    }

    class TwoDistances
    {
        public double Feet { get; set; }
        public double Inches { get; set; }
        public double SumInInch => Feet * 12.0 + Inches;
    }

    class TwoTimes
    {
        public TwoTimes()
        {
            var date1 = new DateTime(2021, 1, 1);
            var date2 = new DateTime(2021, 1, 7);

            Console.WriteLine(new DateTime(date2.Ticks + date1.Ticks));
        }
    }

    class SecondsToTime
    {
        public SecondsToTime(int totalSeconds)
        {

            var hours = totalSeconds / 3600;
            totalSeconds -= hours * 3600;
            var minutes = totalSeconds / 60;
            totalSeconds -= minutes * 60;
            var seconds = totalSeconds;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        }
    }

    class TimeToSeconds
    {
        public TimeToSeconds(int hours, int minutes, int seconds)
        {
            seconds = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine(seconds);
        }
    }

    class Election
    {
        public Dictionary<string,int> Candidates { get; set; }

        public void GetWinner()
        {
            Console.WriteLine(Candidates.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
        }
    }

    class Account
    {
        private string _name;
        private double _amount;
        public string Personal => $"Name is {_name}, Amount is {_amount}";

        public Account(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public void Deposit(double amount)
        {
            _amount += amount;
        }

        public void WithDraw(double amount)
        {
            if (_amount >= amount)
            {
                _amount -= amount;
            }
            else
            {
                throw new Exception("You want withdraw more than you have");
            }
        }
    }
    
}
