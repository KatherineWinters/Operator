using OperatorExercise;
using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.Write("Enter the radius: ");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            double area = AreaOfCircle(radius);
            Console.WriteLine(area);
        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}

