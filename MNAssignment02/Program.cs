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
            int width, length;
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
                        length = Int32.Parse(Console.ReadLine());
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
                        width = Int32.Parse(Console.ReadLine());
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

            

        }
    }
}
