using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    internal static class SettingClass
    {
        public static string SetEmployeeName()
        {
            bool flag = true;
            string empName = default;

            while (flag)
            {
                Console.Write("Enter employee name: ");

                empName = Console.ReadLine();

                if (!(string.IsNullOrEmpty(empName) && string.IsNullOrWhiteSpace(empName)))
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Error! Name cannot be null or empty.\n");
                }
            }

            return empName;
        }

        //TODO: checking input parametr
        public static int SetSalary(DateTime employmentDate)
        {
            int salary = default;
            int expirience = DateTime.Now.Year - employmentDate.Year;

            if (expirience < 5)
            {
                salary = expirience * 20 + 20;
            }
            else
            {
                salary = expirience * 30;
            }

            return salary;        
        }

        public static string SetPhoneNumber()
        {
            string phoneNumber = "+375-29-";

            Random rnd = new Random();

            for (var i = 0; i < 8; i++)
            {
                phoneNumber += rnd.Next(0, 9);
            }

            return phoneNumber;
        }

        public static DateTime SetEmploymentDate()
        {
            bool flag = true;
            DateTime employmentDate = default;

            while (flag)
            {
                Console.Write("Enter employment date (yyyy,mm,dd): ");

                bool isCorrectDate = DateTime.TryParse(Console.ReadLine(), out employmentDate);
                bool correctDate = (employmentDate > new DateTime(2010, 1, 1)) && (employmentDate < DateTime.Now);

                if (isCorrectDate && correctDate)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Error. Date should be more than 2010,1,1.\n");
                }
            }

            return employmentDate;
        }
    }
}
