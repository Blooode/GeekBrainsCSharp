namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) Console.WriteLine("num1 > num2");
            else if (num1 < num2) Console.WriteLine("num1 < num2");
            else Console.WriteLine("num1 = num2");
        }
    }
}