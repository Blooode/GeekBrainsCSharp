// Напишите программу, которая заполнит спирально массив 4 на 4.

namespace Task_5
{
    internal class Program
    {
        static void Show2DArrayInConsole(int[,] matrix)
        {
            int zeroCountInMax = 0;
            int maxValue = matrix.Length;
            while (maxValue > 9)
            {
                maxValue /= 10;
                zeroCountInMax++;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int zeroCount = 0;
                    if (matrix[i, j].ToString().Length - 1 != zeroCountInMax)
                    {
                        zeroCount = zeroCountInMax - matrix[i, j].ToString().Length;
                        for (int k = 0; k <= zeroCount; k++)
                        {
                            Console.Write("0");
                        }
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    else Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Fill2DArraySpirally(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int x = 0;
            int y = 0;
            int currentCount = 1;
            while (size > 0)
            {
                for (int i = y; i <= y + size - 1; i++)
                {
                    matrix[x, i] = currentCount++;
                }

                for (int j = x + 1; j <= x + size - 1; j++)
                {
                    matrix[j, y + size - 1] = currentCount++;
                }

                for (int i = y + size - 2; i >= y; i--)
                {
                    matrix[x + size - 1, i] = currentCount++;
                }

                for (int i = x + size - 2; i >= x + 1; i--)
                {
                    matrix[i, y] = currentCount++;
                }

                x = x + 1;
                y = y + 1;
                size = size - 2;
            }
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int size = GetInput("Enter the amount of rows and columns: ");
            int[,] matrix = new int[size, size];

             Fill2DArraySpirally(matrix);
            Show2DArrayInConsole(matrix);
        }
    }
}