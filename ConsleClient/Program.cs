namespace ConsleClient
{
    internal class Program
    {
        private readonly PersonManager _manager;

        public Program()
        {
            _manager = new PersonManager();
        }

        public void Run()
        {
            var adults = _manager.GetAllAdults();
            Console.WriteLine($"### Erwachsenen ({adults.Count()}) ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));

            var children = _manager.GetAllChildren();
            Console.WriteLine($"### Kinder ({children.Count()}) ###");
            children.ToList().ForEach(p => Console.WriteLine(p.Name));
        }


        static void Main(string[] args)
        {
            var app = new Program();
            app.Run();
        }
    }
}