// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

using System.Threading.Channels;

namespace Task_1
{
    internal class Program
    {
        static int ShowNumbersInInterval(int number)
        {
            Console.Write($"{number} ");
            if (number == 1) return 1;
            else return ShowNumbersInInterval(number - 1);
        }

        static int GetInputNumber(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int maxNumber = GetInputNumber("Enter the final number: ");
            ShowNumbersInInterval(maxNumber);
        }
    }
}