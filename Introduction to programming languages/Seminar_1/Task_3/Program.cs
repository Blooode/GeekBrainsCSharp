namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("Even number");
            else Console.WriteLine("Odd number");
        }
    }
}