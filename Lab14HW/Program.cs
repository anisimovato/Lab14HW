﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14HW
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Say();
        public Animal()
        {
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name); Say();
        }




        class Cat : Animal
        {
            public Cat(string name)
            {
                Name = "Кошка";
            }
            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
            public new void ShowInfo()
            {
                Console.WriteLine(Name); Say();
                Console.ReadKey();
            }
        }





        class Dog : Animal
        {
            public Dog(string name)
            {
                Name = "Пес";
            }
            public override void Say()
            {
                Console.WriteLine("Гав");
            }
               public new void ShowInfo()
            {
                Console.Write(Name); Say();
                Console.ReadKey();
            }

        }
    }
}




//Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
//•	абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:
//•	конструктор, устанавливающий значение по умолчанию для названия;
//•	абстрактный метод Say(), который выводит звук, который издает животное;
//•	неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
//•	свойство – название животного;
//•	метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
