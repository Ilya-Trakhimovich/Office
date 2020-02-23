using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    internal class Manager : Employee
    {
        public Manager()
        {
            Name = Settings.SetName("employee");
            EmploymentDate = Settings.SetEmploymentDate();           
            PhoneNumber = Settings.SetPhoneNumber();
            Position = "Chief";
        }

        public override void GetSalary()
        {
            int expirience = DateTime.Now.Year - this.EmploymentDate.Year;

            if (expirience < 5)
            {
                Salary = expirience * 50 + 40;
            }
            else
            {
                Salary = expirience * 70;
            }
        }

        public override void DisplayInformation()
        {
            Console.WriteLine(
                $"Name: {this.Name}\n" +
                $"Position: {this.Position}\n" +
                $"Employment date: {this.EmploymentDate.ToShortDateString()}\n" +
                $"Salary: {this.Salary}$/month\n" +
                $"Phone number: {this.PhoneNumber}\n");
            Console.ReadKey();
        }
    }
}
