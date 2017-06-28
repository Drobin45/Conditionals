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

            //Console.WriteLine("How many people are in your party?");
            //double totalParty = double.Parse(Console.ReadLine());

            //Console.WriteLine("How much did meal cost?");
            //double totalCost = double.Parse(Console.ReadLine());

            //Console.WriteLine("Meals over 50$ recieve a 10% discount and even purchases under 50$ recieve a 5%!");
            //double individualCost = (totalCost / totalParty);


            //double cost = totalCost;
            //if (cost >= 50)
            //{
            //    Console.WriteLine("You get a 10% discount!");

            //    double bigDiscount = (totalCost * .9);
            //    Console.WriteLine(bigDiscount);
            //    double finalCost = (bigDiscount / totalParty);
            //    Console.WriteLine("Your after before split is");
            //    Console.WriteLine(finalCost);
            //}
            //else
            //{
            //    Console.WriteLine("You get a 5% discount!");
            //    double littleDiscount = (totalCost * .95);
            //    Console.WriteLine(littleDiscount);
            //    double finalCost = (littleDiscount / totalParty);
            //    Console.WriteLine("Your total after split is");
            //    Console.WriteLine(finalCost);
            //}


            Console.WriteLine("Demographic report based on age");
            Console.WriteLine("What is your child's age?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Print: Still in moma's arms!");
            }

            else if (age >= 3 && age <= 4)
            {
                Console.WriteLine("Print: preschool maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Print: elementary school");
            }

            else if (age >=12 && age <= 14)
            {
                Console.WriteLine("Print: Middle School");
            }

            else if (age >=15 && age <=18)
            {
                Console.WriteLine("Print: High School");
            }
            else if (age >=19 && age <=22)
            {
                Console.WriteLine("Pring: College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Print: Workin' for the man! :(");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("Print: The Golden Years!");
            }
            
            
            {   

            //string loyaltyLevel = "red";
            //switch (loyaltyLevel)
            //{
            //    case "yellow":
            //        Console.WriteLine("Discount: 40%");
            //        break;
            
            
            //    case "red":
            //        Console.WriteLine("Discount: 90%");
            //        break;
            //    default:
            //        Console.WriteLine("Error!");
            //        break;
            //}
            


            
            //Console.WriteLine("Spell out your number?");
            
            //string number = Console.ReadLine();
            //switch (number)
            //{
            //    case "One":
            //        Console.WriteLine("1");
            //        break;

            //    case "Two":
            //        Console.WriteLine("2");
            //        break;

            //    case "Three":
            //        Console.WriteLine("3");
            //        break;

            //    case "Four":
            //        Console.WriteLine("4");
            //        break;

            //    case "Five":
            //        Console.WriteLine("5");
            //        break;

            //    case "Six":
            //        Console.WriteLine("6");
            //        break;

            //    case "Seven":
            //        Console.WriteLine("7");
            //        break;

            //    case "Eight":
            //        Console.WriteLine("8");
            //        break;

            //    case "Nine":
            //        Console.WriteLine("9");
            //        break;

            //    case "Ten":
            //        Console.WriteLine("10");
            //        break;

            //    default:
            //        Console.WriteLine("You're an eff'n moron!?");
            //        break;

            }

        }
    }
}
