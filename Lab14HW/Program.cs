using System;
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


            Cat cat = new Cat("Мурка");
            Dog dog = new Dog("Полкан");
            dog.ShowInfo();
            cat.ShowInfo();

            Console.ReadKey();

        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
        public Animal()
        {
           
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }




        public class Cat : Animal
        {
            public override string Name { get; set; }
            public Cat(string name)
                : base()
            {
                Name = name;

            }
            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
            public Cat()
                : base()
            {
            }
        }





        public class Dog : Animal
        {
            public override string Name { get; set; }
            public Dog(string name)
                : base()

            {
                Name = name;

            }
            public override void Say()
            {
                Console.WriteLine("Гав");
            }
            public Dog()
                : base()
            { 
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

