using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green; 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("********************");
            Console.WriteLine("**** Мой проект ****");
            Console.WriteLine("********************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            Console.ReadLine();
        }
    }
}