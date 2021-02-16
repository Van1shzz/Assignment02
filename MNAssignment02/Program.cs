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
            int input = 0;
            bool checkLength = false;
            bool checkWidth = false;
            bool checkLength2 = false;
            bool checkWidth2 = false;
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
                catch (Exception )
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
                catch (Exception)
                {
                    Console.WriteLine("Enter an integer");

                }
            }
                Rectangle rectangle = new Rectangle(width, length);

               

                while (input != 7)
                {
                    Console.WriteLine("1.Get Rectangle Length\n2.Change Rectangle Length\n3.Get Rectangle Width\n4.Change Rectangle Width" +
                                   "\n5.Get Rectangle Perimeter\n6.Get Rectangle Area\n7.Exit");
                try { 
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter a number from 1-7");
                }

                    

                    

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("The length of the rectanle is: " + rectangle.GetLength().ToString());
                            break;
                        case 2:                            
                            while (checkLength2 == false)
                            {
                            Console.WriteLine("enter a new LENGTH for the rectangle");
                            try
                                {                                   
                                    newInput = Int32.Parse(Console.ReadLine());
                                    if (newInput <= 0)
                                    {
                                        Console.WriteLine("enter a positive integer");
                                    }
                                    else
                                    {
                                        rectangle.SetLength(newInput);                                       
                                        checkLength2 = true;
                                                                              
                                    }                                   
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("enter an integer");
                                    
                                }

                            }
                            checkLength2 = false;
                            break;
                        case 3:
                            Console.WriteLine("The width for the rectangle is: " + rectangle.GetWidth().ToString());
                            input = Int32.Parse(Console.ReadLine());
                            break;
                        case 4:
                        while (checkWidth2 == false)
                        {
                            Console.WriteLine("enter a new WIDTH for the rectangle");
                            try
                            {
                                newInput = Int32.Parse(Console.ReadLine());
                                if (newInput <= 0)
                                {
                                    Console.WriteLine("enter a positive integer");
                                }
                                else
                                {
                                    rectangle.SetLength(newInput);
                                    checkWidth2 = true;

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("enter an integer");

                            }

                        }
                        checkWidth2 = false;
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

