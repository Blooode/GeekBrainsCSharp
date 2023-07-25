// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2 => k1 * x - k2 * x = b2 - b1 => x * (k1 - k2) = b2 - b1 => x = (b2 - b1) / (k1 - k2) =>
// y = k1 * x + b1, x = (b2 - b1) / (k1 - k2).

namespace Task_2
{
    internal class Program
    {
        static void GetIntersectionPoint(double k1, double b1, double k2, double b2)
        {
            double pointX = (b2 - b1) / (k1 - k2);
            double pointY = k1 * pointX + b1;
            Console.WriteLine($"The intersection point is ({pointX}; {pointY})");
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Functions: y = k1 * x + b1; y = k2 * x + b2");
            double k1 = GetInput("Enter the k1: ");
            double b1 = GetInput("Enter the b1: ");
            double k2 = GetInput("Enter the k2: ");
            double b2 = GetInput("Enter the b2: ");
            GetIntersectionPoint(k1, b1, k2, b2);
        }
    }
}