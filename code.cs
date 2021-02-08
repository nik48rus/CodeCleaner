using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /*
    Основной класс программы
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green; // Форматируем шапку программы
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("********************");
            Console.WriteLine("**** Мой проект ****");
            Console.WriteLine("********************");
            // Основная программа
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            // Ожидание нажатия клавиши Enter перед завершением работы
            Console.ReadLine();
        }
    }
}