// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

namespace Task_1
{
    internal class Program
    {
        static void GiveRandomValueDouble(double[,] matrix)
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;  j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(random.NextDouble() + random.Next(-99, 100), 2);
                }
            }
        }

        static void MatrixOutput(double[,] matrix)
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

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            double[,] matrix = new double[GetInput("Enter the number of columns: "),
                                          GetInput("Enter the number of rows: ")];
            GiveRandomValueDouble(matrix);
            MatrixOutput(matrix);
        }
    }
}