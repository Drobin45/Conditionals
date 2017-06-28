using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many people are in your party?");
            double totalParty = double.Parse(Console.ReadLine());

            Console.WriteLine("How much did meal cost?");
            double totalCost= double.Parse(Console.ReadLine());

            Console.WriteLine("Meals over 50$ recieve a 10% discount and even purchases under 50$ recieve a 5%!");
            double individualCost = (totalCost / totalParty);

            
            double cost = totalCost;
            if(cost >= 50)
            { Console.WriteLine("You get a 10% discount!");

                double bigDiscount = (totalCost * .9);
                Console.WriteLine(bigDiscount);
                double finalCost = (bigDiscount / totalParty);
                Console.WriteLine("Your after before split is");
                Console.WriteLine(finalCost);
            }
            else
            { Console.WriteLine("You get a 5% discount!");
                double littleDiscount = (totalCost * .95);
                Console.WriteLine(littleDiscount);
                double finalCost = (littleDiscount / totalParty);
                Console.WriteLine("Your total after split is");
                Console.WriteLine(finalCost);
            }

            
            

        }
    }
}
