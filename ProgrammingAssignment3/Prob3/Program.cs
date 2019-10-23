/*
 Author: Regina Pilipchuk
 Partner: Cody M.
 Programming Assignment 3
 Problem 3: Aggregation & Composition

 Instructions:
 Demonstrate both the aggregation and composition relationships
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create manager
            Manager manager = new Manager("John", "Smith", 3648);
            
            // create an employee 
            Employee regina = new Employee("Hired", manager);
            regina.UpdateManagerInfo("Regina", "Pilipchuk", 1527);

            // print results
            Console.WriteLine("Employee Status:\t{0}", regina.EmpStatus.ToUpper());
            Console.WriteLine();
            regina.PrintManagerInfo();
            Console.WriteLine();
        }
    }
}
