using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    internal class Manager : Employee
    {
        public DateTime EmploymentDate { get; private set; }
        
        public Manager()
        {
            EmploymentDate = SettingClass.SetEmploymentDate();
            Name = SettingClass.SetEmployeeName();
            Salary = SettingClass.SetSalary(EmploymentDate);
            PhoneNumber = SettingClass.SetPhoneNumber();
        }

        public override void DisplayInformation()
        {
            Console.WriteLine(
                $"Name: {this.Name}\n" +
                $"Employment date: {this.EmploymentDate.ToShortDateString()}\n" +
                $"Salary: {this.Salary}\n" +
                $"Phone number: {this.PhoneNumber}\n");
        }
    }
}
