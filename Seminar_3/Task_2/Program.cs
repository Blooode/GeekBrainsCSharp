// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

namespace Task_2
{
    internal class Point
    {
        public int x, y, z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        static public void GetPointInfo()
        {
            Console.WriteLine("Enter coordinates X, Y and Z: ");
        }
    }

    internal class Program
    {
        static double GetDistance(Point point1, Point point2, out double distance)
        {
            return distance = Math.Round(Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2) + Math.Pow(point2.z - point1.z, 2)), 2);
        }

        static void Main(string[] args)
        {
            Point.GetPointInfo();
            Point point1 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Point.GetPointInfo();
            Point point2 = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            double distance = GetDistance(point1, point2, out distance);
            Console.WriteLine($"Расстояние между двумя точками в 3D-пространстве равно {distance}");
        }
    }
}