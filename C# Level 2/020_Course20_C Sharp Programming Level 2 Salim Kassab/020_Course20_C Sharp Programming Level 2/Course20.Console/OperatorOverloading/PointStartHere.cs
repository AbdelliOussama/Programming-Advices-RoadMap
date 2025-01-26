using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course20.Console.OperatorOverloading_006
{
    internal class PointStartHere
    {
        public PointStartHere() => startHere();

        private void startHere()
        {
            Point point1 = new(1, 2);
            Point point2 = new(3, 4);

            System.Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
            System.Console.WriteLine($"point2: ({point2.X}, {point2.Y})");

            Point point3 = point1 + point2;
            System.Console.WriteLine($"point3 is the result of point1 + point2 : ({point3.X},{point3.Y})");

            Point point4 = point1 - point2;
            System.Console.WriteLine($"point4 is the result of point1 - point2 : ({point4.X},{point4.Y})");


            System.Console.Write($"using ==: ");
            if (point1 == point2)
                System.Console.WriteLine("Yes, point1 equals to point2");
            else
                System.Console.WriteLine("No, point1 doesn't equals to point2");


            System.Console.Write($"using !=: ");
            if (point1 == point2)
                System.Console.WriteLine("Yes, point1 equals to point2");
            else
                System.Console.WriteLine("No, point1 doesn't equals to point2");

        }
    }


}
