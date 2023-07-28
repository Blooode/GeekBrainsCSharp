// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

namespace Task_2
{
    internal class Program
    {
        static string FindValueOfElement(ref int column, ref int row, ref int[,] matrix)
        {
            if (column >= matrix.GetLength(0) || column < 0 || row >= matrix.GetLength(1) || row < 0)
                return "This element doesn't exist.";

            return "Value of this element is " + matrix[column, row].ToString() + ".";
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

        static void GenerateRandomValuesInt(int[,] matrix)
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 100);
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
            Random random = new Random();
            int[,] matrix = new int[random.Next(5, 21), random.Next(5, 16)];
            GenerateRandomValuesInt(matrix);
            MatrixOutput(matrix);

            int column = GetInput("Enter the number of a column: ");
            int row = GetInput("Enter the number of a row: ");
            string value = FindValueOfElement(ref column, ref row, ref matrix);
            Console.WriteLine(value);
        }
    }
}