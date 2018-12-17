using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Square : twoDimensionalShape //inherting the 2d dimensional an abstract class
    {
        
        private double Lenght;

        public Square() { SetData();  }

        public Square(double Width, double Lenght) : base(Width, Lenght)
        {




        }
        public override double CalculateArea()
        {
           return Lenght * Lenght;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the Lenght :");
            Lenght = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a Square the lenght  " + Lenght + " Area " + CalculateArea());
        }
    }
}
