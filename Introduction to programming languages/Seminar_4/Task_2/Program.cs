// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

using System.ComponentModel;

namespace Task_2
{
    internal class Program
    {
        static int GetDigitSum(int number)
        {
            int result = 0;

            foreach (char digit in number.ToString())
            {
                result += digit - 48;
            }

            return result;
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int number = GetInput("Enter the number: ");
            int result = GetDigitSum(number);
            Console.WriteLine($"Result is {result}");
        }
    }
}