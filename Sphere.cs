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
    class Sphere : threeDimensionalShape //inherting the 3d dimensional an abstract class
    {
        double radius;
        public Sphere()
        {
            SetData();
        }

        public Sphere(double Width, double Lenght, double Height, double radius) : base(Width, Lenght, Height)
        {



        }

        public override double CalculateArea()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override double CalculateVolume()
        {
            return (4 / 3) * (Math.PI * radius * radius * radius);
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the radius : ");
            radius = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a Sphere the length " + radius + " Area " + CalculateArea() + " Volume " + CalculateVolume());
        }
    }
}
