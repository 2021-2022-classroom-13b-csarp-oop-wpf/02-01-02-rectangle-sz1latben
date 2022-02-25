using System;
using RectangleProject.Models;

namespace RectangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle t1 = new Rectangle(2.5, 3.3);
            Rectangle t2 = new Rectangle(3.5, 4.1);





            if (t1.Area > t2.Area)
            {
                Console.WriteLine("A nagyobb területű téglalap kerülete: " + t1.Perimeter);
            }

            else if (t2.Area > t1.Area)
            {
                Console.WriteLine("A nagyobb területű téglalap kerülete: " + t2.Perimeter);
            }
            else
            {
                Console.WriteLine("A két téglalap területe megegyezik! Kerületük:" + t1.Perimeter);
            }
                
        }
    }
}
