using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Manager
    {
        // auto properties of manager
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int empID { get; set; }

        // default constructor
        public Manager() { }

        // master constructor
        public Manager(string fName, string lName, int id)
        {
            firstName = fName;
            lastName = lName;
            empID = id;
        }

        // print method
        public void PrintManager()
        {
            Console.WriteLine("*** METHOD FROM MANAGER CLASS ***");
            Console.WriteLine("=== MANAGER INFORMATION ===");
            Console.WriteLine("Name:\t{0} {1}", firstName, lastName);
            Console.WriteLine("Employee ID:\t{0}", empID);
        }
    }
}
