using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Employee : User
    {
        #region this code pertains to access modifiers
        // field
        protected string userType;
        public string GetUserType() { return userType; }
        public void SetUserType(string type)
        {
            userType = type;
        }


        // constructors
        // default constructor
        public Employee() 
        {
            Console.WriteLine("Employee Default Constructor");
        }
        public Employee(string name, int id, string userType)
            // calls constructor from base class
            // child has no access to base private field
            : base(name, id)
        {
            Console.WriteLine("Employee Master Constructor");
            this.userType = userType;
        }

        // create a method that overrides the base PrintState() method
        public override void PrintState()
        {
            Console.WriteLine("** Info. from Employee Class:");
            // this allows access to private field
            base.PrintName();
            // prints protected field from parent
            Console.WriteLine(this.id);
            // prints field from child
            Console.WriteLine("User Type: {0}", userType);
        }
        #endregion
    }
}
