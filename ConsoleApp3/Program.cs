using System;
using System.Runtime.InteropServices.ComTypes;
using System.Web;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "Джордж Оруэлл", 328);
            Book book2 = new Book("Скотный двор", "Джордж Оруэлл", 160);
            Book book3 = new Book("Капитанская дочка", "Александр Пушкин", 352);
            book1.PrintInfo();
            book2.PrintInfo();
            book3.PrintInfo();
            Student student1 = new Student("Алиса", 20, "ИС-202");
            Student student2 = new Student("Борис", 19);
            student1.ShowInfo();
            student2.ShowInfo();
            Car myCar = new Car("Nissan Skyline X (R34) 1998", 45000);
            myCar.Drive(200);
            myCar.ShowMileage();
            Rectangle rect = new Rectangle(10, 20);
            rect.GetArea();
            rect.PrintInfo();
            BankAccount myBank = new BankAccount(0);
            myBank.Deposit(500);
            myBank.Withdraw(250);
            myBank.ShowBalance();
            Console.ReadKey();
        }
    }
    class Book
    {
        public string Name;
        public string Author;
        public int Pages;
        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            Pages = pages;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Name}, Автор: {Author}, Страниц: {Pages}");
        }

    }
    class Student
    {
        public string Name;
        public int Age;
        public string Group;

        public Student(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Group = "Неизвестная группа";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
        }
    }
    class Car
    {
        public string Brand;
        public int Mileage;
        public Car(string brand, int mileage)
        {
            Brand = brand;
            Mileage = mileage;
        }
        public void Drive(int distance)
        {
            Mileage = Mileage + distance;
        }
        public void ShowMileage()
        {
            Console.WriteLine($"Ваш текущий пробег у машины {Brand}: {Mileage} км");
        }
    }
    class Rectangle
    {
        public int Width;
        public int Height;
        public int Area;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void GetArea()
        {
            Area = Width * Height;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Ширина:{Width}\n Высота:{Height}\nПлощадь: {Area}");
        }
    }
    class BankAccount
    {
        public int Balance;
        public BankAccount(int balance)
        {
            Balance = balance;
        }
        public void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Деньги успешно зачислены");
        }
        public void Withdraw(int amount)
        {
            Balance = Balance - amount;
            if (Balance <= 1)
            {
                Console.WriteLine("На вашем балансе недостаточно средств");
                Balance = Balance + amount;
            }
            else
            {
                Console.WriteLine($" С вашего банковского счета списана сумма в размере: {amount} руб\n Ваш баланс после операции: {Balance}");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($" Ваш текущий баланс: {Balance}");
        }
    }
}