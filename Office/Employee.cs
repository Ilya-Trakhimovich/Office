using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    abstract class Employee
    {
        protected string Name { get; set; }
        public int Salary { get; set; }
        protected string PhoneNumber { get; set; }
        public abstract void DisplayInformation();
    }
}
