using System;
using System.ComponentModel.DataAnnotations;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.WriteLine("Enter three numbers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Max number is {max}");
        }
    }
}