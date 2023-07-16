// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = -1;

            foreach (int i  in number.ToString())
            {
                count++;
            }
            if (count >= 2) Console.WriteLine($"The third is {number.ToString().Substring(2, 1)}");
            else Console.WriteLine("The third is absent");
        }
    }
}