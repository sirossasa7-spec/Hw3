namespace Hw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website site = new Website();

            site.Input();

            Console.WriteLine("\nІнформація про сайт:");
            Console.WriteLine(site);
        }
    }
    class Website
    {
        private string name;
        private string path;
        private string description;
        private string url;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public void Input()
        {
            Console.Write("Назва сайту: ");
            Name = Console.ReadLine();

            Console.Write("Шлях до сайту: ");
            Path = Console.ReadLine();

            Console.Write("Опис сайту: ");
            Description = Console.ReadLine();

            Console.Write("Адреса сайту: ");
            Url = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Назва: {Name}\n" +
                   $"Шлях: {Path}\n" +
                   $"Опис: {Description}\n" +
                   $"Адреса: {Url}";
        }
    }
}
