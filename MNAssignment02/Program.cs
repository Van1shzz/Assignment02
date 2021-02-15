using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MNAssignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length and width of the rectangle");
            int width = 0;
            int length=0;
            int newInput=0;
            bool checkLength = false;
            bool checkWidth = false;
            Console.WriteLine("What is your LENGTH?");

            //get the user length
            while (checkLength == false)
            {
                try
                {
                    length = Int32.Parse(Console.ReadLine());

                    if (length <= 0)
                    {
                        Console.WriteLine("Enter a positive integer");                       
                    }
                    else
                    {
                        checkLength = true;                      
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter an integer");
                }
            }

            //get the user width
            Console.WriteLine("What is your WIDTH?");
            while (checkWidth == false)
            {
                try
                {
                    width = Int32.Parse(Console.ReadLine());

                    if (width <= 0)
                    {
                        Console.WriteLine("Enter a positive integer");
                        
                    }
                    else
                    {
                        checkWidth = true;                        
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter an integer");

                }

                Rectangle rectangle = new Rectangle(width, length);

                Console.WriteLine("1.Get Rectangle Length\n2.Change Rectangle Length\n3.Get Rectangle Width\n4.Change Rectangle Width" +
                                    "\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");



                int input= Int32.Parse(Console.ReadLine());


                while(input != 7)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("The length of the rectanle is: " + rectangle.GetLength().ToString());
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("enter a new LENGTH for the rectangle");
                            newInput = Int32.Parse(Console.ReadLine());
                            rectangle.SetLength(newInput);
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("The width for the rectangle is: " + rectangle.GetWidth().ToString());
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("enter a new WIDTH for the rectangle");
                            newInput = Int32.Parse(Console.ReadLine());
                            rectangle.SetWidth(newInput);
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("The perimeter of your rectangle is: " + rectangle.GetPerimeter().ToString());
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("The Area of your rectangle is: " + rectangle.GetArea().ToString());
                            input = Int32.Parse(Console.ReadLine());
                            
                            break;
                        case 7:
                            Console.WriteLine("press any key to exit");
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        default:
                            break;
                    }
                }

                



            }
        }
    }
}

