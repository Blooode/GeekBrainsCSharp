// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

namespace Task_4
{
    internal class Program
    {
        static bool IfValueIsSame(int numberInArray, ref bool count)
        {
            if (!count)
            {
                count = true;
                return false;
            }
            else return true;
        }

        static void Show3DArrayInConsole(int[,,] array)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Fill3DArrayWithInt(int[,,] array, int minValue, int maxValue)
        {
            bool[] counts = new bool[maxValue - minValue + 1];
            Random random = new Random();

            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int j = 0;
                    while (j < array.GetLength(1))
                    {
                        array[i, j, k] = random.Next(minValue, maxValue + 1);
                        if (!IfValueIsSame(array[i, j, k], ref counts[array[i, j, k] - minValue])) j++;
                        else continue;
                    }
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
            int minValue, maxValue;
            int posY, posX, posZ;
            do
            {
                minValue = GetInput("Enter the minimal value in array: ");
                maxValue = GetInput("Enter the maximal value in array: ");

                posY = GetInput("Enter the size in Y dimension: ");
                posX = GetInput("Enter the size in X dimension: ");
                posZ = GetInput("Enter the size in Z dimension: ");
            }
            while (posY * posX * posZ > maxValue - minValue + 1);
            int[,,] numbers = new int[posY, posX, posZ];

            Fill3DArrayWithInt(numbers, minValue, maxValue);
            Show3DArrayInConsole(numbers);
        }
    }
}