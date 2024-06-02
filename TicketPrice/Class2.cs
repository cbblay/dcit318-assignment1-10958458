using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    public class Class2
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
           
            if( age <= 12 || age >= 65)
            {
                Console.WriteLine("The price of your ticket is GHC7");
            }
            else
            {
                Console.WriteLine("The price of your ticket is GHC10");
            }
        }
    }
}
