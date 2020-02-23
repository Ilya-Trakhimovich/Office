using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    abstract class Employee
    {
        public string Name { get; set; }
        protected DateTime EmploymentDate { get; set; }
        protected string Position { get; set; }
        protected int Salary { get; set; }
        protected string PhoneNumber { get; set; }
        public abstract void GetSalary();
        public abstract void DisplayInformation();
    }
}
