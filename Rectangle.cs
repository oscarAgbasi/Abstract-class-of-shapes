using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Rectangle : twoDimensionalShape //inherting the 2d dimensional an abstract class
    { 

        private double width;
        private double Lenght;
    



        public Rectangle()
        {
            SetData();

        }

        public Rectangle(double Width, double Lenght) : base(Width, Lenght)
        {




        }



        public override void SetData() 
        {
            Console.WriteLine("Enter the Lenght :");
            Lenght = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width :");
            width = double.Parse(Console.ReadLine());
        }



        public override double CalculateArea()
        {
            return  Lenght * width;
        }

        public override double CalculateVolume()
        {
            return 0;
        }

        public override string ToString()
        {
            return String.Format("This Shape is a Rectangle the lenght  " + Lenght  + "  and the width is " + width + " Area " + CalculateArea());
        }

    }
}
