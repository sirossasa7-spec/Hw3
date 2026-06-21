using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store.Input();

            Console.WriteLine("\nІнформація про магазин:");
            Console.WriteLine(store);
        }
    }
    class Store
    {
        private string name;
        private string address;
        private string profile;
        private string phone;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Profile
        {
            get { return profile; }
            set { profile = value; }
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
            Console.Write("Назва магазину: ");
            Name = Console.ReadLine();

            Console.Write("Адреса: ");
            Address = Console.ReadLine();

            Console.Write("Опис профілю магазину: ");
            Profile = Console.ReadLine();

            Console.Write("Телефон: ");
            Phone = Console.ReadLine();

            Console.Write("E-mail: ");
            Email = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Назва: {Name}\n" +
                   $"Адреса: {Address}\n" +
                   $"Профіль: {Profile}\n" +
                   $"Телефон: {Phone}\n" +
                   $"E-mail: {Email}";
        }
    }
}
