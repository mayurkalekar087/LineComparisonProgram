using System;

namespace lineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            x1 = 45;
            x2 = 13;
            y1 = 11;
            y2 = 10;
            var distance1 = Math.Sqrt((Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2)));
            Console.WriteLine(distance1);

            int x3, x4, y3, y4;
            x3 = 12;
            x4 = 13;
            y3 = 11;
            y4 = 10;
            var distance2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            Console.WriteLine(distance2);
            if (distance1 == distance2)
            {
                Console.WriteLine("Lengths are equal");
            }
            else
            {
                Console.WriteLine("Lengths are not equal");
            }
            if (distance1 > distance2)
            {
                Console.WriteLine("Length 1 is greater than Length 2");
            }
            else
            {
                Console.WriteLine("Length 1 is less than Length 2");
            }
            

        }



           
    }
}
