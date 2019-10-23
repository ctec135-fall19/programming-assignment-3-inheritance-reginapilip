/*
 Author: Regina Pilipchuk
 Partner: Cody M.
 Programming Assignment 3
 Problem 2: Demo of Access Fields and Constructor Calling Sequence

 Instructions:
 Create a class hierarchy that...
 - Demonstrates the effect of the private and protected access modifiers on 
   access to fields from child classes.
 - Demonstrates the calling sequence of constructors.
 - Demonstrates setting and getting field values.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region demo of field access modifiers & constructor calling sequence
            // demo on the effect of the private and protected access modifiers
            // on access to fields from child classes

            // create a new base class object (user) and print its state
            Console.WriteLine("* ACCESS MODIFIERS & " +
                                "CONSTRUCTOR CALLING SEQUENCE *\n");
            Console.WriteLine("==== NEW BASE USER ====");
            User newUser = new User("Regina Pilipchuk", 1527);
            newUser.PrintState();
            Console.WriteLine();

            // create a new child class object (employee) and print its state
            Console.WriteLine("==== NEW EMPLOYEE USER ====");
            Employee newEmp = new Employee("Lucy White", 8942, "Employee");
            newEmp.PrintState();
            Console.WriteLine("\n\n");
            #endregion

            #region setting & getting field values
            // setting demo
            Console.WriteLine("* SETTING AND GETTING FIELD VALUES *\n");
            Console.WriteLine("==== SETTING A VALUE ====");
            // create new user object
            User user1 = new User();
            // set name and id
            user1.SetName("Joe King");
            user1.SetId(4466);
            // print via method
            user1.PrintState();
            Console.WriteLine();


            // getting demo
            // use newEmp variable from above to demo getting values
            Console.WriteLine("==== GETTING A VALUE ====\n");
            Console.WriteLine("Employee 1 Stats\n" +
                              "Name:\t{0}\nID:\t{1}\nType:\t{2}\n",
                              newEmp.GetName(), newEmp.GetId(), 
                              newEmp.GetUserType());
            #endregion

        }
    }
}
