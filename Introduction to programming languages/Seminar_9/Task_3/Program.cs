// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

namespace Task_3
{
    internal class Program
    {
        static int AckermanFunction(int numberM, int numberN)
        {
            if (numberM == 0) return numberN + 1;
            else if (numberN == 0) return AckermanFunction(numberM - 1, numberN + 1);
            else return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
        }
        static int GetInputPositiveNumber(string text)
        {
            Console.Write(text);
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0) return GetInputPositiveNumber(text);
            return number;
        }

        static void Main(string[] args)
        {
            int numberM = GetInputPositiveNumber("Enter the non-negative number \"M\": ");
            int numberN = GetInputPositiveNumber("Enter the non-negative number \"N\": ");
            Console.WriteLine($"The result of the function is {AckermanFunction(numberM, numberN)}");
        }
    }
}