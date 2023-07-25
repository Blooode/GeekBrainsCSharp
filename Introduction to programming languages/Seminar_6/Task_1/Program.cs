// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

namespace Task_1
{
    internal class Program
    {
        static void GetAmountOfPositiveNumbers(int numberAmount)
        {
            int countAboveZero = 0;
            for (int i = 1; i <= numberAmount; i++)
            {
                int temporary = GetInput($"Number[{i}] is ");
                if (temporary > 0) countAboveZero++;
            }
            Console.WriteLine($"Amount of positive numbers: {countAboveZero}");
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int numberAmount = GetInput("Enter the amount of numbers: ");
            GetAmountOfPositiveNumbers(numberAmount);
        }
    }
}