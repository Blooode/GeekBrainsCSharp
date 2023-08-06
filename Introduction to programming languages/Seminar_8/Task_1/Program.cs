// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

namespace Task_1
{
    internal class Program
    {
        static int[,] SortMatrixFromMaxToMin(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] tempArray = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++) tempArray[j] = matrix[i, j];
                Array.Sort(tempArray);
                Array.Reverse(tempArray);
                for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = tempArray[j];
            }
            return matrix;
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
            Console.WriteLine();
            SortMatrixFromMaxToMin(matrix);
            ShowMatrixInConsole(matrix);
        }
    }
}