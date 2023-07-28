// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

namespace Task_3
{
    internal class Program
    {
        static void GetAverageInColumns(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int average = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    average += matrix[i, j];
                }
                average /= matrix.GetLength(0);
                Console.Write($"{average}\t");
            }
        }

        static void GenerateValuesOfMatrixInt(int[,] matrix)
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }

        static void MatrixOutput(int[,] matrix)
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

        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[random.Next(5, 21), random.Next(5, 16)];
            GenerateValuesOfMatrixInt(matrix);
            MatrixOutput(matrix);
            Console.WriteLine();
            GetAverageInColumns(matrix);
        }
    }
}