// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

namespace Task_1
{
    internal class Program
    {
        static int RaiseNumber(int number, int degree)
        {
            int result = number;

            for (int i = 1; i < degree; i++)
            {
                result *= number;
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
            int degree = GetInput("Enter the degree: ");

            int result = RaiseNumber(number, degree);
            Console.WriteLine($"Result is {result}");
        }
    }
}