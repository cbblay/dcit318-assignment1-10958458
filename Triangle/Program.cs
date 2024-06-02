using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TriangleBot
{
    internal class Program
    {
        static void Main(string[]args)
        {
            //Get user input for triangle sides
            Console.Write("Enter the value for the first side of the triangle: ");
            int sideOne = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for the second side of the triangle: ");
            int sideTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for the third side of the triangle: ");
            int sideThree = int.Parse(Console.ReadLine());
            
            //Conditions for the type of triangle
            if(sideOne == sideTwo && sideTwo == sideThree)
            {
                Console.Write("It is an equilateral triangle!");
            }else if(sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                Console.Write("You have an isosceles triangle!");
            }
            else
            {
                Console.Write("The triangle is Scalene!");
            }
        }
    }
}
