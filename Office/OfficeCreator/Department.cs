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
                Console.ReadKey();
            }
            else
            {
                Chief = new Manager();
                isChief = true;
            }
        }

        public void DismissEmployee()
        {
            if (CheckOnEmptyDepartment())
            {
                string name = Settings.SetName("employee");
                string position = Settings.GetPosition();

                if (Chief?.Name == name && Chief.Position == position)
                {
                    Chief = null;
                    isChief = false;
                }

                if (listOfEmployees.Count != 0)
                {
                    for (var i = 0; i < listOfEmployees.Count; i++)
                    {
                        if (listOfEmployees[i]?.Name == name && listOfEmployees[i]?.Position == position)
                        {
                            listOfEmployees[i] = null;
                        }
                    }
                }
            }
        }

        private bool CheckOnEmptyDepartment()
        {
            if (Chief == null && listOfEmployees.Count == 0)
            {
                Console.WriteLine("The department hasnt employees.\n");
                Console.ReadKey();

                return false;
            }

            return true;
        }

        public void DisplayInformation()
        {
            if (CheckOnEmptyDepartment())
            {
                string name = Settings.SetName("employee");

                if (Chief?.Name == name)
                {
                    Chief.DisplayInformation();
                }

                if (listOfEmployees != null)
                {
                    foreach (var emp in listOfEmployees)
                    {
                        if (emp?.Name == name)
                        {
                            emp.DisplayInformation();
                        }
                    }
                }
            }            
        }
    }
}
