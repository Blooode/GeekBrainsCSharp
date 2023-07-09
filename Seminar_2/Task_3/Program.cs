// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of day: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 6 || number == 7) Console.WriteLine("It's a day off");
            else Console.WriteLine("It's a working day");
        }
    }
}