// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The second is {number.ToString().Substring(1, 1)}");
        }
    }
}