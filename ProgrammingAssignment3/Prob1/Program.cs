/*
 Author: Regina Pilipchuk
 Partner: Cody M.
 Programming Assignment 3
 Problem 1: Using Class Diagramming Tool

 Instructions:
 Create a class hierarchy using ONLY the class diagram tool.
 The hierarchy should be at least 3 deep.
 The hierarchy should be at least 2 wide at the second level (level inheriting from the base).
 The base class should be an abstract class.
Create your own naming scheme. Names should indicate position of class in the hierarchy.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print out some statement explaining this section
            // separate it into a region?
            Console.WriteLine("====== DEMO OF USING ABSTRACT METHODS ======\n");
            // create a dog object and tell it to sleep, eat, and exercise
            Console.WriteLine("DOG:");
            Dogs dog1 = new Dogs();
            Console.WriteLine(dog1.Eat());
            Console.WriteLine(dog1.Sleep());
            // create a mammal object and tell it to sleep, eat, and exercise
            Console.WriteLine("\nMAMMAL:");
            Mammals mammal1 = new Mammals();
            Console.WriteLine(mammal1.Eat());
            Console.WriteLine(mammal1.Sleep());
            Console.WriteLine("\n============================================");
        }
    }
}
