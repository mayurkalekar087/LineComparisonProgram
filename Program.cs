using System;

namespace lineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            x1 = 12;
            x2 = 13;
            y1 = 11;
            y2 = 10;
            var distance = Math.Sqrt((Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2)));
            Console.WriteLine(distance);  
        }
    }
}
