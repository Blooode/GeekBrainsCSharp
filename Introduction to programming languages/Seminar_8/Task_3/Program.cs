// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

namespace Task_3
{
    internal class Program
    {
        static int[,] MultipleTwoMatrixes(int[,] matrixFirst, int[,] matrixSecond)
        {
            int maxRowAmount = matrixFirst.GetLength(0) > matrixSecond.GetLength(0)
                             ? matrixFirst.GetLength(0) : matrixSecond.GetLength(0);
            int maxColumnAmount = matrixFirst.GetLength(1) > matrixSecond.GetLength(1)
                                ? matrixFirst.GetLength(1) : matrixSecond.GetLength(1);
            int[,] matrixMultipleResult = new int[maxRowAmount, maxColumnAmount];

            for (int i = 0; i < matrixMultipleResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixMultipleResult.GetLength(1);  j++)
                {
                    int matrixFirstValue = 1;
                    int matrixSecondValue = 1;
                    if (matrixFirst.GetLength(0) > matrixSecond.GetLength(0))
                    {
                        for (int k = 0; k < matrixFirst.GetLength(1); k++) matrixFirstValue *= matrixFirst[i, k];
                        for (int k = 0; k < matrixSecond.GetLength(0); k++) matrixSecondValue *= matrixSecond[k, j];
                    }
                    else
                    {
                        for (int k = 0; k < matrixFirst.GetLength(0); k++) matrixFirstValue *= matrixFirst[k, j];
                        for (int k = 0; k < matrixSecond.GetLength(1); k++) matrixSecondValue *= matrixSecond[i, k];
                    }

                    matrixMultipleResult[i, j] = matrixFirstValue + matrixSecondValue;
                }
            }
            return matrixMultipleResult;
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
            int[,] matrixFirst = new int[
                GetInput("Enter the amount of rows (First matrix) and amount of columns (Second matrix): "),
                GetInput("Enter the amount of columns (First matrix) and amount of rows (Second matrix): ")];

            int[,] matrixSecond = new int[matrixFirst.GetLength(1), matrixFirst.GetLength(0)];

            FillMatrixWithInt(matrixFirst);
            FillMatrixWithInt(matrixSecond);
            ShowMatrixInConsole(matrixFirst);
            Console.WriteLine();
            ShowMatrixInConsole(matrixSecond);
            Console.WriteLine();
            int[,] matrixMultipleResult = (MultipleTwoMatrixes(matrixFirst, matrixSecond));
            ShowMatrixInConsole(matrixMultipleResult);
        }
    }
}