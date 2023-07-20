// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях

namespace Task_2
{
    internal class Program
    {
        static int SumOddIndexNumbers(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i];
            }
            return sum;
        }

        static void ArrayOutput(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static int[] GenerateArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] numbers = GenerateArray(15, 1, 99);
            ArrayOutput(numbers);
            int sum = SumOddIndexNumbers(numbers);
            Console.WriteLine($"\nSum of odd numbers is {sum}");
        }
    }
}