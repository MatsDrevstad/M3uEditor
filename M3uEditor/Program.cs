using System;

namespace M3uEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 180;
            Console.Title = "M3uEditor";
            Console.ForegroundColor = ConsoleColor.Green;
            var sruApplication = new M3uApplication();
        }
    }
}
