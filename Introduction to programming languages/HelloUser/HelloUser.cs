using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloUser
{
    public class HelloUser
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.Write($"Привет, {name}");

            Console.ReadKey();
        }
    }
}