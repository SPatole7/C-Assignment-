using System;
using System.Collections.Generic;

namespace Asssignments_C_sharp
{
    class Circle
    {
        public static void Main()
        {
            Area_Circumference();
        }
        public static void Area_Circumference()
        {
            double circumference, area;
            double pi = Math.PI;
            Console.Write("Enter the radius of Circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            circumference = 2 * pi * radius;
            area = pi * radius * radius;
            Console.WriteLine("Circumference of Circle is: {0}", circumference);
            Console.WriteLine("Area of Circle :{0}", area);
        }
    }
}
