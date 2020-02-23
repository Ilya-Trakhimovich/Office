using System;

namespace Office
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            Department department = menu.Department;
            bool flag = true;

            while (flag)
            {
                int choice = menu.ShowMenu(department);
                var tempChoice = (ActionMenu)choice;

                switch (tempChoice)
                {
                    case ActionMenu.AddChief:
                        {
                            department.AddChief();

                            break;
                        }
                    case ActionMenu.AddHourlyEmployee:
                        {
                            department.AddHourlyEmployee();

                            break;
                        }
                    case ActionMenu.AddSalaredEmployee:
                        {
                            department.AddSalaredEmployee();

                            break;
                        }
                    case ActionMenu.DismissEmployee:
                        {
                            break;
                        }
                    case ActionMenu.DisplayInformation:
                        {
                            department.DisplayInformation();

                            break;
                        }
                    case ActionMenu.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }


                }
            }


        }
    }
}
