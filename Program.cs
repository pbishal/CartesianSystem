using System;

namespace CartesianSyayem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x1: ");
            string x1val = Console.ReadLine();
            int x1 = Convert.ToInt32(x1val);

            Console.WriteLine("Enter the value of x2: ");
            string x2val = Console.ReadLine();
            int x2 = Convert.ToInt32(x2val);

            Console.WriteLine("Enter the value of y1: ");
            string y1val = Console.ReadLine();
            int y1 = Convert.ToInt32(y1val);

            Console.WriteLine("Enter the value of y2: ");
            string y2val = Console.ReadLine();
            int y2 = Convert.ToInt32(y2val);

            double lengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of line 1 is: " + lengthOfLine1);
            Console.ReadLine();
        }
    }
}
