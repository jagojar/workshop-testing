using System;

namespace ConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger = new LoggerUtil();
            //var logger = new LoggerDB();

            //Constructor
            //var service = new Service(logger);           

            // Property Setter
            //var service = new Service(); 
            //service.Logger = logger;

            //Method
            var service = new Service();
            service.AddLogger(logger);

            Console.WriteLine(service.LogMessage("Hello world"));

            Console.ReadLine();
        }
    }
}
