// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

namespace Task_2
{
    internal class Program
    {
        static int FindRowWithMinSum(int[,] matrix)
        {
            int rowWithMinSum = 0;
            int minSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int tempSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempSum += matrix[i, j];
                }
                if (tempSum < minSum)
                {
                    minSum = tempSum;
                    rowWithMinSum = i;
                }
            }
            return rowWithMinSum;
        }

        static void ShowMatrixInConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void FillMatrixWithInt(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-9, 10);
                }
            }
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[GetInput("Enter the amount of rows: "),
                                    GetInput("Enter the amount of columns: ")];

            FillMatrixWithInt(matrix);
            ShowMatrixInConsole(matrix);
            Console.WriteLine($"The row with minimal sum of elements is {FindRowWithMinSum(matrix)}.");
        }
    }
}