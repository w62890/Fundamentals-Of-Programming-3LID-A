using System;
using System.ComponentModel;

namespace Lab10_11_01_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            RPGTest();
        }

        public static void ParentTest()
        {
            var parentMom = new ParentMom();
            var parentDad = new ParentDad();

            parentMom.Message();
            parentDad.Message();
        }

        public static void BalanceTest()
        {
            var testA = new BankA();
            var testB = new BankB();
            var testC = new BankC();

            testA.GetBalance();
            testB.GetBalance();
            testC.GetBalance();
        }

        public static void PoliceCarStatus()
        {
            var policeCar = new PoliceCar();
            policeCar.EmergencyPrintStatus();
            policeCar.LandVehiclePrintStatus();
        }

        public static void RPGTest()
        {
            var warrior = new Warrior();
            var monster = new Monster();
            var objectt = new Object();

            warrior.Attack();
            warrior.Heal();
            monster.Attack();
            objectt.Use();

        }

        abstract class Parent
        {
            public string Name { get; set; }
            public void Message()
            {
                Console.WriteLine(Name);
            }
        }

        class ParentMom : Parent
        {
            public ParentMom()
            {
                Name = "Mom";
            }
        }

        class ParentDad : Parent
        {
            public ParentDad()
            {
                Name = "Dad";
            }
        }

        abstract class Bank
        {
            public int Balance { get; set; }
            public void GetBalance()
            {
                Console.WriteLine(Balance);
            }
        }

        class BankA : Bank
        {
            public BankA()
            {
                Balance = 100;
            }
        }

        class BankB : Bank
        {
            public BankB()
            {
                Balance = 200;
            }
        }

        class BankC : Bank
        {
            public BankC()
            {
                Balance = 300;
            }
        }

        interface IIsEmergency
        {
            public void EmergencyPrintStatus();
        }

        interface IIsLandVehicle : IIsEmergency
        {
            public void LandVehiclePrintStatus();
        }

        class PoliceCar : IIsLandVehicle
        {
            public void EmergencyPrintStatus()
            {
                Console.WriteLine("Some Emergency status");
            }

            public void LandVehiclePrintStatus()
            {
                Console.WriteLine("Some Vehicle status");
            }
        }

        interface IWarrior
        {
            public void Attack();
            public void Heal();
        }

        interface IMonster
        {
            public void Attack();
        }

        interface IObject
        {
            public void Use();
        }

        class Warrior : IWarrior
        {
            public void Attack()
            {
                Console.WriteLine("Attack");
            }

            public void Heal()
            {
                Console.WriteLine("Heal");
            }
        }

        class Monster : IMonster
        {
            public void Attack()
            {
                Console.WriteLine("Attack");
            }
        }

        class Object : IObject
        {
            public void Use()
            {
                Console.WriteLine("Used");
            }
        }
    }
}
