using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the coordinates of the first point
            Console.WriteLine("Enter the x-coordinate of point 1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of point 1:");
            double y1 = double.Parse(Console.ReadLine());

            // Prompt the user to enter the coordinates of the second point
            Console.WriteLine("Enter the x-coordinate of point 2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of point 2:");
            double y2 = double.Parse(Console.ReadLine());

            // Prompt the user to enter the coordinates of the third point
            Console.WriteLine("Enter the x-coordinate of point 3:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of point 3:");
            double y3 = double.Parse(Console.ReadLine());

            // Calculate the length of the three sides
            double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            // Output the length of the three sides
            Console.WriteLine("The length of the three sides are:");
            Console.WriteLine("Side 1: " + side1);
            Console.WriteLine("Side 2: " + side2);
            Console.WriteLine("Side 3: " + side3);

            // Determine whether the triangle is equilateral, isosceles, or right-angled
            bool isEquilateral = (side1 == side2) && (side2 == side3);
            bool isIsosceles = (side1 == side2) || (side1 == side3) || (side2 == side3);
            bool isRightAngled = (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2))
                || (Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2))
                || (Math.Pow(side3, 2) + Math.Pow(side1, 2) == Math.Pow(side2, 2));

            // Output whether the triangle is equilateral, isosceles, or right-angled
            if (isEquilateral)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (isIsosceles)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is neither equilateral nor isosceles.");
            }

            if (isRightAngled)
            {
                Console.WriteLine("The triangle is right-angled.");
            }
            else
            {
                Console.WriteLine("The triangle is not right-angled.");
            }

            // Calculate and output the perimeter of the triangle
            double perimeter = side1 + side2 + side