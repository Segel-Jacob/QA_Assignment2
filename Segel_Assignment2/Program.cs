using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segel_Assignment2
{
    class Program
    {
        public static Rectangle rectangle = new Rectangle();

        public static string length, width;
        static void Main(string[] args)
        {
            bool showMenu = true;
            
            Console.Write("\n\n");
            Console.Write("Assignment -- 2\n");
            Console.Write("-------------------------------------------------------\n");
            Console.Write("\n\n");

            Console.Write("Please enter the Length of the Rectangle: ");            
            length = Console.ReadLine();
            if (CheckInteger(length))
            {
                rectangle.SetLength(Convert.ToInt32(length));
            }
            else
            {
                Console.WriteLine("Length must be an integer greater than zero!");
            }

            Console.Write("Please enter the Width of the Rectangle: ");
            width = Console.ReadLine();
            if (CheckInteger(width))
            {
                rectangle.SetWidth(Convert.ToInt32(width));
            }
            else
            {
                Console.WriteLine("Width must be an integer greater than zero!");
            }

            while (showMenu)
            {
                showMenu = DisplayMenu();
            }
            Console.ReadLine();
        }
        public static bool DisplayMenu()
        {
            Console.Clear();
            
            Console.Write("\n\n");
            Console.Write("Please select from the following options: \n");
            Console.Write(" 1.Get Rectangle Length \n 2.Change Rectangle Length \n" +
                " 3.Get Rectangle Width \n 4.Change Rectangle Width \n 5.Get " +
                "Rectangle Perimeter \n 6.Get Rectangle Area \n 7.Exit");
            Console.Write("\n\n");

            Console.Write("\nInput your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("\nRectangle length is: " + length);
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.Write("\nEnter new rectangle length: ");
                    length = Console.ReadLine();
                    if (!CheckInteger(length))
                    {
                        Console.WriteLine("Please enter a valid integer!");
                        Console.ReadLine();
                        return false;
                    }
                    rectangle.SetLength(Convert.ToInt32(length));
                    Console.WriteLine("Length changed to: " + rectangle.GetLength());
                    Console.ReadLine();
                    return true;
                    
                case "3":
                    Console.Write("\nRectangle width is: " + width);
                    Console.ReadLine();
                    return true;
                    
                case "4":
                    Console.Write("\nEnter new rectangle width: ");
                    if (CheckInteger(Console.ReadLine()))
                    {
                        rectangle.SetWidth(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nRectangle width has been changed to: " + rectangle.GetWidth());
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Please enter a valid integer!");
                        Console.ReadLine();
                    }
                    return true;
                case "5":
                    Console.Write("\nRectangle Perimeter is: " + rectangle.GetPerimeter());
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Write("\nRectangle Area is: " + rectangle.GetArea());
                    Console.ReadLine();
                    return true;
                case "7":
                    Environment.Exit(0);
                    return false;
                default:
                    return true;
            }
        }
        public static bool CheckInteger(string num)
        {
            if (!int.TryParse(num, out int result))
            {
                return false;
            }
            else
            {
                if (CheckNumber(Convert.ToInt32(num)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
        public static bool CheckNumber(int num)
        {
            if (num>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
