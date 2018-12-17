/**
 * Agbasi Oscar, 000333302
 * 12th oct, 2018
 * Program purpose : used abstract class to make reuse able code 
 * Statement of Authorship :I, Agbasi Oscasr, 000333302 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Boolean exitApp = false; 
            string Choice; // user option variable
            var shapesOfShapes = new List<Shape>();//  arrayylist of shapes


            do
            {


                //Prompting the user for input
                Console.WriteLine("Oscar's Geometry Class: ");
                Console.WriteLine("A - Rectangle  E - Ellipse  I - Triangle \n " + "B - Square     F - Circle   J - Tetrahedron \n" +
                                  "C - Box        G - Cylinder \n" +
                                  "D - Cube       H - Sphere \n");
                Console.WriteLine();
                Console.WriteLine("0 - List all Shape and Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice: )  <" + Shape.GetCount() + " Shape entered so far>");
                Choice = Console.ReadLine();
                String Choiceupper = Choice.ToUpper(); //convert the string to upper
                                                       //





                switch (Choiceupper)
                {
                    case "A":
                        shapesOfShapes.Add(new Rectangle()); // adding rectangle to the shape list
                        Console.Clear();// clear the screen;

                        break;

                    case "B":
                        shapesOfShapes.Add(new Square()); // adding square to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "C":
                        shapesOfShapes.Add(new Box());// adding box to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "D":
                        shapesOfShapes.Add(new Cube());// adding cube to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "E":
                        shapesOfShapes.Add(new Ellipse());// adding ellipse to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "F":
                        shapesOfShapes.Add(new Circle());// adding circle to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "G":
                        shapesOfShapes.Add(new Cyclinder());// adding cyclinder to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "H":
                        shapesOfShapes.Add(new Sphere());// adding sphere to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "I":
                        shapesOfShapes.Add(new Triangle());// adding triangle to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "J":
                        shapesOfShapes.Add(new tetrahedron());// adding tetrahedron to the shape list
                        Console.Clear();// clear the screen;
                        break;

                    case "0":

                        exitApp = true;

                        foreach (var shape in shapesOfShapes) { Console.WriteLine(shape); }

                        break;

                    default :
                        Console.WriteLine("The choice you picked isnt in the option please Try again");
                         String clearApp = Console.ReadLine();
                        Console.Clear();
                        break;
                }
                //
                


            } while (!exitApp);
          
            Console.ReadLine();
        }
    }
}
