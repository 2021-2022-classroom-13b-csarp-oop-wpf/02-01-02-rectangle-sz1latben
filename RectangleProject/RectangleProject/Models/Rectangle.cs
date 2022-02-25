using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                this.sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                this.sideB = value;
            }
        }
        public double Area
        {
            get
            {
                return sideA * sideB;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (this.sideA + this.sideB);
            }
        }

        public override string ToString()
        {
            return "A téglalap egyik oldala: " + sideA + ", a másik oldala: " + sideB + ", a kerülete: " + Math.Round(Perimeter, 2) + ", területe: " + Math.Round(Area, 2) + ".";
        }
    }
}
