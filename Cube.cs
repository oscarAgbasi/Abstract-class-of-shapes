/*
  Class:  Sphere.cs
  Author: Agbasi oscar
  Date:   September 4, 2017

  Purpose: This  class that inhertict method from the abstract class

           
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Cube: threeDimensionalShape //inherting the 3d dimensional an abstract class
    {
        private double length;
        public Cube()
        {
            SetData();
        }

        public Cube(double Width, double Lenght, double Height, double radius) : base(Width, Lenght, Height)
        {



        }

        public override double CalculateArea()
        {
            return 6 * (length * length );
        }

        public override double CalculateVolume()
        {
            return length * length * length;
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the length ");
            length = double.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return String.Format("This Shape is a cube the length " + length + " Area " + CalculateArea() + " Volume " + CalculateVolume());
        }
    }
}
