using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    internal static class Settings
    {
        public static string SetName(string instance)
        {
            bool flag = true;
            string empName = default;

            while (flag)
            {
                Console.Write($"Enter {instance} name: ");

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

        public static void DisplayDepartment(Department dep)
        {
            if (dep != null)
            {
                Console.WriteLine(dep.Chief?.Name);

                foreach (var emp in dep.listOfEmployees)
                {
                    Console.WriteLine($"{emp?.Name}\n\n");
                }
            }
        }
    }
}
