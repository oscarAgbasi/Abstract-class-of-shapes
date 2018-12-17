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
    class Triangle : twoDimensionalShape //inherting the 2d dimensional an abstract class
    {
        private double baseOfTraingle;
        private double height;
        public Triangle() { SetData(); }

        public Triangle(double Width, double Lenght) : base(Width, Lenght)
        {




        }

        public override double CalculateArea()
        {
            return (baseOfTraingle * height) / 2.0;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the Base : ");
            baseOfTraingle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return String.Format("This Shape is a Triangle the height " + height + " baseOfTraingle " + baseOfTraingle + " Area " + CalculateArea() + " Volume " + CalculateVolume());
        }
    }
}
