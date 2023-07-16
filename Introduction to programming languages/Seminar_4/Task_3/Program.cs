// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

namespace Task_3
{
    internal class Program
    {
        static void GetOutput(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }

        static int GetRandomInput()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

        static int GetInput(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            int chooser;
            bool isRandom = false;

            Console.WriteLine("Enter the numbers by a keyboard or choose random numbers?"
                             + " 1. Enter by a keyboard; 2. Random generation");
            do
            {
                chooser = Convert.ToInt32(Console.ReadLine());
            }
            while (chooser != 1 && chooser != 2);

            switch (chooser)
            {
                case 1: isRandom = false; break;
                case 2: isRandom = true; break;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!isRandom) numbers[i] = GetInput($"Enter the {i} digit: ");
                else numbers[i] = GetRandomInput();
            }
            GetOutput(numbers);
        }
    }
}