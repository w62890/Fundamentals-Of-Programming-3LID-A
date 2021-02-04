using System;
using System.Collections.Generic;

namespace Lab13_01_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Event();
        }

        public static void StructTest()
        {
            Company comp;
            comp.name = "Wsiz";
            
            Employee emp1;
            emp1.firstname = "Sunil";
            emp1.lastname = "Sunil";
            emp1.company = comp;

            Employee emp2;
            emp2.firstname = "Krul";
            emp2.lastname = "Krul";
            emp2.company = comp;

            Employee[] arr = new[] {emp1, emp2};

            foreach (var employee in arr)
            {
                Console.WriteLine($"Emp {employee.firstname} {employee.company}");
            }

        }

        public static void BookTest()
        {
            Book book1;
            book1.name = "metro";
            book1.autor = "glux";
            book1.isbn = "312321";

            Book book2;
            book2.name = "math";
            book2.autor = "math";
            book2.isbn = "322322";

            Console.WriteLine($"isbn of 1 {book1.isbn}, isbn of 2 {book2.isbn}");
        }
        
        delegate int Rnd();

        public static int GetRand()
        {
            var random = new Random();
            return random.Next();
        }

        public static void Delegate()
        {
            Rnd rnd;
            rnd = GetRand;
            Console.WriteLine(rnd());

        }
        
        public delegate void Message(string message);
        public static event Message Notify;
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void Event()
        {
            Notify += DisplayMessage;
            var arr = new List<string>() { "Sunil", "Steven", "Mathew"};
            foreach (var name in arr)
            {
                if (name == "Steven" || name == "Mathew")
                {
                    Notify?.Invoke("Banned");
                }
                else
                {
                    Notify?.Invoke("Hi bro");

                }
            }
        }

        public struct Book
        {
            public string isbn;
            public string name;
            public string autor;
        }

        public struct Company
        {
            public string name;
        }

        public struct Employee
        {
            public string firstname;
            public string lastname;

            public Company company;
        }
    }
}
