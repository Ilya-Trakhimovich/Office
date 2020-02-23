using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class SalaredEmployee : Employee
    {
        public SalaredEmployee()
        {
            Name = Settings.SetName("employee");
            EmploymentDate = Settings.SetEmploymentDate();
            PhoneNumber = Settings.SetPhoneNumber();
            Position = "Salared employee";
        }        

        public override void GetSalary()
        {
            int expirience = DateTime.Now.Year - this.EmploymentDate.Year;

            if (expirience < 8)
            {
                Salary = expirience * 20 + 20;
            }
            else
            {
                Salary = expirience * 30;
            }
        }

        public override void DisplayInformation()
        {
            Console.WriteLine(
                $"Name: {this.Name}\n" +
                $"Posotion: {this.Position}\n" +
                $"Employment date: {this.EmploymentDate.ToShortDateString()}\n" +
                $"Salary: {this.Salary}$/month\n" +
                $"Phone number: {this.PhoneNumber}\n");
            Console.ReadKey();
        }
    }
}
