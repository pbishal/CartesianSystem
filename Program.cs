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

            Console.WriteLine("Enter the value of p1: ");
            string p1val = Console.ReadLine();
            int p1 = Convert.ToInt32(p1val);

            Console.WriteLine("Enter the value of p2: ");
            string p2val = Console.ReadLine();
            int p2 = Convert.ToInt32(p2val);

            Console.WriteLine("Enter the value of q1: ");
            string q1val = Console.ReadLine();
            int q1 = Convert.ToInt32(q1val);

            Console.WriteLine("Enter the value of q2: ");
            string q2val = Console.ReadLine();
            int q2 = Convert.ToInt32(q2val);

            double lengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of line 1 is: " + lengthOfLine1);

            double lengthOfLine2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            Console.WriteLine("The length of line 2 is: " + lengthOfLine2);

            Console.WriteLine(lengthOfLine1.Equals(lengthOfLine2));

            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Two lines are equal");
            }
            else if (lengthOfLine1 > lengthOfLine2)
            {
                Console.WriteLine("lengthOfLine1 is greater than lengthOfLine2");
            }
            else if(lengthOfLine1 < lengthOfLine2)
            {
                Console.WriteLine("lengthOfLine1 is less than lengthOfLine2");
            }
            else
            {
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}
