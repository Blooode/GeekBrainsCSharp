// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i;

            for (i = 0; i < number.ToString().Length / 2; i++)
            {
                if (number.ToString()[i] == number.ToString()[number.ToString().Length - i - 1])
                {
                    count++;
                }
            }
            if (count == i) Console.WriteLine("It's a palindrome");
            else Console.WriteLine("It's not a palindrome");
        }
    }
}