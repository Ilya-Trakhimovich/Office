using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee()
        {
            Name = Settings.SetName("employee");
            PhoneNumber = Settings.SetPhoneNumber();
            Position = "Hourly employee";
        }

        public override void GetSalary()
        {
            Random rnd = new Random();

            Salary = rnd.Next(20,40) / 3;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine(
                $"Name: {this.Name}\n" +
                $"Position: {this.Position}\n" +
                $"Salary: {this.Salary}$/hour\n" +
                $"Phone number: {this.PhoneNumber}\n");
            Console.ReadKey();
        }        
    }
}
