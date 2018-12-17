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
    class Box : threeDimensionalShape //inherting the 3d dimensional an abstract class
    {
        private double length;

        private  double width;

        private double height;

        double Area;

        double volume;

        public Box() {
            SetData();
        }

        public Box(double Width, double Lenght, double Height) : base( Width,  Lenght,  Height) {



        }
        public override double CalculateArea()
        {
            return Area = (2 * (height * width) + 2 * (height * length) * +2 * (width * length));
        }

        public override double CalculateVolume()
        {
            return volume = length * height * width;
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the Lenght :");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width :");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width :");
            height = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a box the lenght " + length + " and the width is " + width + " and the height is " + height + " Area " + Area + " Volume " + volume);
        }
    }
}
