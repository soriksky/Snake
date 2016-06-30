using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,4,'#');
            p1.Draw();

            List < Point > listPoint = new List<Point>();
            listPoint.Add(p1);
            Console.ReadLine();
        }
    }
}
