using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Employee
    {
        // define properties/fields
        public string EmpStatus { get; set; }
        private Manager manager;
        // aggregation
        private Manager manager2;

        // constructor
        public Employee(string status, Manager m)
        {
            // composition
            EmpStatus = status;
            // invokes Manager class default constructor
            // composition
            manager = new Manager();
            // aggregation
            manager2 = m;
        }

        // methods
        public void UpdateManagerInfo(string fName, string lName, int id)
        {
            Console.WriteLine("*** METHOD FROM EMPLOYEE CLASS ***");
            manager.firstName = fName;
            manager.lastName = lName;
            manager.empID = id;
        }

        public void PrintManagerInfo()
        {
            Console.WriteLine("*** METHOD FROM EMPLOYEE CLASS ***");
            manager.PrintManager();
            manager2.PrintManager();
        }
    }
}
