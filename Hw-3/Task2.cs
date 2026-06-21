using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_3
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine();

            magazine.Input();

            Console.WriteLine("\nІнформація про журнал:");
            Console.WriteLine(magazine);
        }
    }
    class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Input()
        {
            Console.Write("Назва журналу: ");
            Name = Console.ReadLine();

            Console.Write("Рік заснування: ");
            Year = int.Parse(Console.ReadLine());

            Console.Write("Опис журналу: ");
            Description = Console.ReadLine();

            Console.Write("Телефон: ");
            Phone = Console.ReadLine();

            Console.Write("E-mail: ");
            Email = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Назва: {Name}\n" +
                   $"Рік заснування: {Year}\n" +
                   $"Опис: {Description}\n" +
                   $"Телефон: {Phone}\n" +
                   $"E-mail: {Email}";
        }
    }
}
