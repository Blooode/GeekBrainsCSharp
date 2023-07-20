// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве
namespace Task_1
{
    internal class Program
    {
        static int EvenNumbersInArray(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }

        static void ArrayOutput(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }

        static int[] GenerateArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] new_array = new int[length];

            for (int i = 0; i < length; i++)
            {
                new_array[i] = random.Next(min, max + 1);
            }

            return new_array;
        }

        static void Main(string[] args)
        {
            int[] numbers = GenerateArray(15, 100, 999);
            ArrayOutput(numbers);
            Console.WriteLine($"\nThe count of even numbers is {EvenNumbersInArray(numbers)}");
        }
    }
}