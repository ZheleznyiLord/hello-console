using System;

namespace hello_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var message = getMessage("World");
            Console.WriteLine(message);
        }

        private static string getMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
