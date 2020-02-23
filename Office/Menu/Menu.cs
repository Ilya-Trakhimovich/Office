using System;
using System.Collections.Generic;
using System.Text;

namespace Office
{
    internal class Menu
    {
        public Department Department { get; } = new Department();
        private const string _arrow = "--> ";
        private readonly string[] _menu =
            {
                "  Add a chief",
                "  Add an salared employee",
                "  Add a hourly employee",
                "  Dismiss an employee",
                "  Display information",
                "  Exit."
            };

        private void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t***** {Department.Name} ***** \n\n");
            Console.ResetColor();
        }

        private void MoveArrow(int moveChoice, Department dep)
        {
            Console.Clear();
            Welcome();
            Settings.DisplayDepartment(dep);

            for (var i = 0; i < _menu.Length; i++)
            {
                if (i == moveChoice)
                {
                    Console.Write(_arrow);
                }

                Console.WriteLine(_menu[i]);
            }
        }

        public int ShowMenu(Department dep)
        {
            int choice = 0;            
            Console.CursorVisible = false;

            while (true)
            {
                MoveArrow(choice, dep);                

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (choice != 0)
                            {
                                --choice;
                            }

                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (choice != _menu.Length - 1)
                            {
                                ++choice;
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            return choice;
                        }
                }
            }
        }
    }
}
