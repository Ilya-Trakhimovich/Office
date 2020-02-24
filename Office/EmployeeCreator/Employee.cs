using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    abstract class Employee
    {
        public string Name { get; set; }
        protected DateTime EmploymentDate { get; set; }
        public string Position { get; set; }
        protected int Salary { get; set; }
        protected string PhoneNumber { get; set; }
        protected abstract void GetSalary();
        public abstract void DisplayInformation();
    }
}
