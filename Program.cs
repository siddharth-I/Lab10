using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("Circumference: " + circumference);
            Console.WriteLine("Area: " + area);
        }
    }
}
