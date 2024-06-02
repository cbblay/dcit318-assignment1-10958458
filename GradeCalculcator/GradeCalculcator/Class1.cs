using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculcator
{
    public class Class1
    {
        static void Main(string[]args)
        {
            Console.Write("Enter your score: ");
            //Calling for user input
            string input = Console.ReadLine();
            int score;
            //Conditions for various scores and grade
            if (int.TryParse(input,out score))
            {
                if(score < 0 || score > 100)
                {
                    Console.WriteLine("Error! Score must be between 0 & 100");
                else if (score >= 90)
                {
                    Console.WriteLine("Grade:A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Grade:B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Grade:C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Grade:D");
                }
                else
                {
                    Console.WriteLine("Grade:F");
                }

                
            }
        }

    }
}
