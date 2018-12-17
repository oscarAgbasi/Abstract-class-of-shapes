using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class tetrahedron : threeDimensionalShape //inherting the 3d dimensional an abstract class
    {
        private double length;

        public tetrahedron() { SetData();  }


        public tetrahedron(double Width, double Lenght, double Height) : base(Width, Lenght, Height)
        {



        }

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (length *length);
        }

        public override double CalculateVolume()
        {
            return ((Math.Sqrt(2)) / 12) * (3 * (length));
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the Lenght :");
            length = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a tetrahedron the lenght " + length + " Area " + CalculateArea() + " Volume " + CalculateVolume());
        }
    }

}
