// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

namespace Task_2
{
    internal class Program
    {
        static int ShowNumbersInInterval(int maxNumber, int minNumber)
        {
            Console.Write($"{maxNumber} ");
            if (maxNumber == minNumber) return minNumber;
            else return ShowNumbersInInterval(maxNumber - 1, minNumber);
        }

        static int GetInputNumber(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int maxNumber = GetInputNumber("Enter the maximal number: ");
            int minNumber = GetInputNumber("Enter the minimal number: ");
            ShowNumbersInInterval(maxNumber, minNumber);
        }
    }
}