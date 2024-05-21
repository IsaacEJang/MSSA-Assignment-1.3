using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3
{
    internal class Program
    {
        //PART 1 - AREA OF TRIANGLE
        static double areaOfTriangle(double triangleArea)
        {
            //base
            Console.Write("\nEnter the base: ");
            float x = float.Parse(Console.ReadLine());

            //height
            Console.Write("Enter the hieght: ");
            float y = float.Parse(Console.ReadLine());

            //area of trianlge
            triangleArea = 0.5 * x * y;

            //prints area in yellow
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\nArea of Triangle: " + triangleArea);
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine();

            //returns area of triangle
            return triangleArea;
        }

        //PART 1 - AREA OF SQUARE
        static double areaOfSquare(double squareArea)
        {
            //base & height 
            Console.Write("\nEnter the base or height: ");
            float x = float.Parse(Console.ReadLine());

            //area of square
            squareArea = x * x;

            //prints area in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nArea of Square: " + squareArea);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //returns area of square
            return squareArea ;
        }

        //PART 1 - AREA OF RECTANGLE
        static double areaOfRectangle(double rectangleArea)
        {
            //base
            Console.Write("\nEnter the base: ");
            float x = float.Parse(Console.ReadLine());

            //height
            Console.Write("Enter the hieght: ");
            float y = float.Parse(Console.ReadLine());

            //area of rectangle
            rectangleArea = x * y;

            //prints area in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nArea of Rectangle: " + rectangleArea);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //returns area of square
            return rectangleArea;
        }

        //PART 1 - MENU OF AREAS
        static string menuOfAreas(string choice)
        {
            Console.WriteLine("I can calculate the area of shapes \n");
            Console.WriteLine("Type the letter next to the shape that you want: \n\n" +
                "   A: Triangle\n" +
                "   B: Square\n" +
                "   C: Rectanle\n");
            Console.WriteLine("If you want to move onto part 2, type 'next':");

            choice = Console.ReadLine();
            return choice;

        }


        static void Main(string[] args)
        {
            // PART 1
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 1.3");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 1");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(); // spacer

            /*
           1.Write a program in C# to calculate area of triangle, square and rectangle.
           Write 3 different functions for each shape to take dimensions of figure and display the area. 
           You may create menus.
            */

            // variable
            string choice = null;
            string userInput = null;
            double triangleArea = 0;
            double squareArea = 0;
            double rectangleArea = 0;

            // menuOfAreas functions call
            userInput = menuOfAreas(choice).ToUpper();

            while (userInput != "NEXT")
            {
                switch (userInput)
                {
                    // triangle functions call
                    case "A":

                        triangleArea = areaOfTriangle(triangleArea);
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nArea of Triangle: " + triangleArea);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        break;

                    case "B":
                        areaOfSquare(squareArea);
                        break;

                    case "C":
                        areaOfRectangle(rectangleArea);
                        break;

                    case "EXIT":
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You didn't enter one of the options. Please try again.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }

                // recalls menuOfAreas
                userInput = menuOfAreas(choice).ToUpper();

                continue;

            }

            // Transition
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to move on to PART 2\n");
            Console.ReadKey();

            //PART 2

            /*
            2.Write a program in C# to read n number of values in an array and display it in reverse order.
            Test Data :

            Input the number of elements to store in the array :3
            Input 3 number of elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 7
            
            Expected Output
            The values store into the array are:
            2 5 7
            The values store into the array in reverse are :
            7 5 2
             */

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 2");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine(); // spacer

            Console.WriteLine("Give me an array/list of numbers and I will give you the reverse order:\n");

            // creates array named "elements"
            int[] elements;

            Console.WriteLine("How many elements do you want to add?"); //asks user for size of array
            var size = int.Parse(Console.ReadLine()); // assigns variable size to number user inputs

            elements = new int[size]; // declaring size of element to user input

            Console.WriteLine(); // spacer


            // for loop so user can input elements
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element - {i} : ");
                elements[i] = int.Parse(Console.ReadLine());
            }

            // for loop to print out elements
            Console.WriteLine("\nThe values store into the array are:");
            Console.ForegroundColor = ConsoleColor.Yellow; // highlights answer
            for (int i = 0; i < size; i++ ) 
            {
                Console.Write(elements[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White; // back to white

            // for loop to print elements in reverse order
            Console.WriteLine("\n\nThe values store into the array in reverse are:");
            Console.ForegroundColor = ConsoleColor.Yellow; // highlights answer
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }

            // closing message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();

        }
    }
}
