// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;  i <= number; i++)
            {
                Console.Write($"{Math.Pow(i, 3)} ");
            }
        }
    }
}