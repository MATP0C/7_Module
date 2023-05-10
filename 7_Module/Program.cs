using System;
using System.Net.Mail;

namespace Module
{
    public class Person
    {
        int age = 1;
        public virtual int Age
        {
            get => age;
            set { if (value > 0 && value < 110) age = value; } //Использование свойств с логикой в get и/или set блоках.
        }
        public string Name { get; set; }
        public Person(string name) //Использование конструкторов классов с параметрами;
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person //Использование наследования;
    {
        public override int Age //Использование переопределений методов/свойств;
        {
            get => base.Age;
            set { if (value > 17 && value < 110) base.Age = value; } //Использование свойств;
        }
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
            base.Age = 18;
        }
        public override void Print() //Использование переопределений методов/свойств;
        {
            base.Print();
            Console.WriteLine($"работает в {Company}");
        }
    }
    public class Product<T> //Использование обобщений;
    {
        public static T? code; //
        public T Id { get;}
        public string Title { get;}
        public Product(T id, string title)
        {
            Id = id;
            Title = title;
            vegetables = new Vegetables();
            fruit = new Fruit();
        }
        class Vegetables { } //Использование композиции классов;
        class Fruit { } //Использование композиции классов;
        private Vegetables vegetables;
        private Fruit fruit;
    }
    abstract class Delivery //Использование абстрактных классов или членов класса;
    {
        public string Address;
    }   
    class HomeDelivery : Delivery
    {
    }

    class PickPointDelivery : Delivery //Использование наследования;
    {
        private double place;
        public double Place
        {
            get => place;
            set => place = value > 0 ? value : throw new Exception("Место в пункте выдачи не может быть менее 0"); //Использование принципов инкапсуляции;
        }
    }

    class ShopDelivery : Delivery
    {
    }

    class Order<TDelivery,TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}