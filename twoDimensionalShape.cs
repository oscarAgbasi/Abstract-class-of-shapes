using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    abstract class twoDimensionalShape : Shape
    {

        private double width;
        private double lenght;


        public twoDimensionalShape() { }


        public twoDimensionalShape(double Width, double Lenght)
        {
            this.lenght = Lenght;
            this.width = Width;
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
                } else

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

                if (value > 0 )
                {

                    Lenght = value;
                } else

                throw new Exception("Wrong input");

            }

        }

        





    }
}
