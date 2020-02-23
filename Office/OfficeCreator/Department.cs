using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    class Department
    {
        private bool isChief = false;
        public string Name { get; private set; }
        public Manager Chief { get; set; }        
        public HourlyEmployee OrdinaryHourlyEmployee { get; set; }
        public SalaredEmployee OrdinarySalaredEmployee { get; set; }

        public readonly List<Employee> listOfEmployees = new List<Employee>();

        public Department()
        {
            Name = Settings.SetName("department");
        }

        public void AddSalaredEmployee()
        {
            Employee employee = new SalaredEmployee();
            listOfEmployees.Add(employee);
        }

        public void AddHourlyEmployee()
        {
            Employee employee = new HourlyEmployee();
            listOfEmployees.Add(employee);
        }

        public void AddChief()
        {
            if (isChief)
            {
                Console.WriteLine("Error. The department has chief. The chief should be alone.");
            }
            else
            {
                Chief = new Manager();
                isChief = true;
            }
        }

        public void DisplayInformation()
        {
            if (Chief == null && listOfEmployees.Count == 0)
            {
                Console.WriteLine("The department hasnt employees.\n");
                Console.ReadKey();
            }
            else
            {
                string name = Settings.SetName("employee");

                if (this.Chief?.Name == name)
                {
                    Chief.DisplayInformation();
                }

                if (listOfEmployees != null)
                {
                    foreach (var emp in listOfEmployees)
                    {
                        if (emp.Name == name)
                        {
                            emp.DisplayInformation();
                        }
                    }
                }
            }            
        }
    }
}
