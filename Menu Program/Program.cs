using System;
using System.Collections.Generic;

namespace Menu_Program
{
    class Program
    {
        enum Gender
        {
            M,
            F,
        }

        class Employee
        {
            public int ID;
            public string Name;
            public double Salary;
            public Gender Gender;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int highlight = 0;
            bool flag = true;
            string[] menu = new string[]
            {
                "  New  ",
                "Display",
                " Sort  ",
                " Exit  "
            };

            int xDistance = Console.WindowWidth / 2;
            int yDistance = Console.WindowHeight / (menu.Length + 1);

            do
            {
                Console.ResetColor();
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(xDistance - menu[i].Length / 2, (i + 1) * yDistance);
                    Console.WriteLine(menu[i]);
                }
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        highlight = (highlight - 1 + menu.Length) % menu.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight = (highlight + 1) % menu.Length;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                AddNewEmployee(employees);
                                break;
                            case 1:
                                DisplayEmployees(employees);
                                break;
                            case 2:
                                SortMenu(employees);
                                break;
                            case 3:
                                flag = false;
                                break;
                        }
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                }
            } while (flag);
        }

        static void SortMenu(List<Employee> employees)
        {
            string[] sortOptions = new string[]
            {
                "Sort by ID",
                "Sort by Name",
                "Sort by Salary"
            };

            int xDistance = Console.WindowWidth / 2;
            int yDistance = Console.WindowHeight / (sortOptions.Length + 1);
            int highlight = 0;

            bool subFlag = true;
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Select sorting option:");

                for (int i = 0; i < sortOptions.Length; i++)
                {
                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(xDistance - sortOptions[i].Length / 2, (i + 1) * yDistance);
                    Console.WriteLine(sortOptions[i]);
                }

                ConsoleKeyInfo subInfo = Console.ReadKey();
                switch (subInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        highlight = (highlight - 1 + sortOptions.Length) % sortOptions.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight = (highlight + 1) % sortOptions.Length;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                SortEmployees(employees, new EmployeeIDComparer());
                                break;
                            case 1:
                                SortEmployees(employees, new EmployeeNameComparer());
                                break;
                            case 2:
                                SortEmployees(employees, new EmployeeSalaryComparer());
                                break;
                        }
                        DisplayEmployees(employees);
                        Console.WriteLine("Sorting completed. Press Enter to continue...");
                        Console.ReadLine();
                        subFlag = false;
                        break;
                }
            } while (subFlag);
        }

        static void SortEmployees(List<Employee> employees, IComparer<Employee> comparer)
        {
            employees.Sort(comparer);
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            Console.WriteLine("Employee List:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Salary: {employee.Salary}, Gender: {employee.Gender}");
            }
        }

        static void AddNewEmployee(List<Employee> employees)
        {
            Console.Write("Enter the ID of the employee: ");
            int IDemployee = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the new employee: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter the salary of the employee: ");
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter the gender of the employee (M/F): ");
            Gender employeeGender;
            Enum.TryParse(Console.ReadLine(), out employeeGender);

            employees.Add(new Employee
            {
                ID = IDemployee,
                Name = employeeName,
                Salary = employeeSalary,
                Gender = employeeGender
            });

            Console.WriteLine("New employee added successfully!");
        }

        class EmployeeIDComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.ID.CompareTo(y.ID);
            }
        }

        class EmployeeNameComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        class EmployeeSalaryComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.Salary.CompareTo(y.Salary);
            }
        }
    }
}
