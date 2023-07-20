// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементами массива

namespace Task_3
{
    internal class Program
    {
        static double MinValueInArray(double[] array)
        {
            double min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }

            return min;
        }

        static double MaxValueInArray(double[] array)
        {
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }

        static void ArrayOutput(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{array[i]}] ");
            }
        }

        static double[] GenerateDoubleArray(int length, int min, int max)
        {
            Random random = new Random();
            double[] array = new double[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * random.Next(min, max + 1), 2);
            }
            return array;
        }

        static void Main(string[] args)
        {
            double[] numbers = GenerateDoubleArray(15, 0, 99);
            ArrayOutput(numbers);

            double max = MaxValueInArray(numbers);
            double min = MinValueInArray(numbers);
            Console.WriteLine($"\nResult is {Math.Round(max - min, 2)}");
        }
    }
}