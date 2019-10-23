using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    // this is the base class
    class User
    {
        #region this code pertains to access modifiers
        // fields (private and protected)
        private string name;
        public string GetName() { return name; }
        public void SetName(string userName)
        {
            name = userName;
        }
        protected int id;
        public int GetId() { return id; }
        public void SetId(int userId)
        {
            id = userId;
        }

        // default constructor
        public  User() : this("something", 123) 
        {
            Console.WriteLine("User Default Constructor");
        }

        // master constructor
        // allows us to get and set names and id
        public User(string name, int id)
        {
            Console.WriteLine("User Master Constructor");
            this.name = name;
            this.id = id;
        }

        // method to print items
        public virtual void PrintState()
        {
            Console.WriteLine("** Info. from User Class:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("User ID: {0}", id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name: {0}", name);
        }
        #endregion
    }
}
