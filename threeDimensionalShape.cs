using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
   abstract class threeDimensionalShape : Shape
    {
        private double width;
        private double lenght;
        private double height;

        public threeDimensionalShape() { }


        public threeDimensionalShape(double Width, double Lenght, double Height)
        {
            this.lenght = Lenght;
            this.width = Width;
            this.height = Height;
        }

        public double Width
        {

            get
            {

                return width;
            }

            set
            {

                if (value > 0)
                {

                    width = value;
                }
                else

                    throw new Exception("Wrong input");

            }
        }

        public double Lenght
        {

            get
            {

                return Lenght;
            }

            set
            {

                if (value > 0)
                {

                    Lenght = value;
                }
                else

                    throw new Exception("Wrong input");

            }

        }

        public double Height
        {

            get
            {

                return Height;
            }

            set
            {

                if (value > 0)
                {

                    Height = value;
                }
                else

                    throw new Exception("Wrong input");

            }

        }


    }
}
