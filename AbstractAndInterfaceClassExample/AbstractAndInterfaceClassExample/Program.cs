using System;
using System.Collections.Generic;
using static System.Console;

namespace AbstractAndInterfaceClassExample
{
    class Program
    {

        private static List<Student> students = new List<Student>();
        private static List<Employee> employees = new List<Employee>();

        private static void AddStudent()
        {
            WriteLine("Enter Student Information:");
            String first = HelperClass.GetString("Enter first name: ");
            String last = HelperClass.GetString("Enter last name: ");
            String street = HelperClass.GetString("Enter street address: ");
            String city = HelperClass.GetString("Enter city: ");
            String state = HelperClass.GetString("Enter state: ");
            String zip = HelperClass.GetString("Enter zipcode: ");
            String phoneNumber = HelperClass.GetString("Enter phone number: ");
            String major = HelperClass.GetString("Enter student's major: ");
            students.Add(new Student(first, last, street, city, state, zip, phoneNumber, major));
            HelperClass.PressAnyKey("Student has been added. Press any key to continue.");
        }

        private static void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                WriteLine("\n\nThere are no students to view yet.\n");
            }
            else
            {
                Clear();
                WriteLine("Students List:\n");
                for (int i = 0; i < students.Count; i++)
                {
                    WriteLine(students[i].GetStudentInfo());
                }
            }
        }

        private static void AddStudentGrade()
        {
            if (students.Count == 0)
            {
                HelperClass.PressAnyKey("There are no students to add grades to. Press any key to continue.");
            }
            else
            {
                int choice = 0;
                Clear();
                ViewAllStudents();
                choice = HelperClass.GetInteger("Enter id of Student to add a grade to: ");
                if ((choice <= 0) || (choice > students.Count))
                {
                    HelperClass.PressAnyKey("That is not a valid student ID, Press any key to continue.");
                }
                else
                {
                    double grade = HelperClass.GetDouble("Enter the grade to add: ");
                    string message = "";
                    if ((grade < 0) || (grade > 100))
                    {
                        message += "That grade is less than zero or greater than 100 and cannot be added. ";
                    }
                    else
                    {
                        students[choice - 1].AddGrade(grade);
                        message += "That grade of " + grade + " has been added.";
                    }
                    HelperClass.PressAnyKey(message + " Press any key to continue.");
                }
            }
        }

        private static void AddEmployee()
        {
            WriteLine("Enter Employee Information:");
            String first = HelperClass.GetString("Enter first name: ");
            String last = HelperClass.GetString("Enter last name: ");
            String street = HelperClass.GetString("Enter street address: ");
            String city = HelperClass.GetString("Enter city: ");
            String state = HelperClass.GetString("Enter state: ");
            String zip = HelperClass.GetString("Enter zipcode: ");
            String phoneNumber = HelperClass.GetString("Enter phone number: ");
            Decimal salary = HelperClass.GetDecimal("Enter employee's salary: ");
            employees.Add(new Employee(first, last, street, city, state, zip, phoneNumber, salary));
            HelperClass.PressAnyKey("Employee has been added. Press any key to continue.");
        }

        private static void ViewAllEmployees()
        {
            if (employees.Count == 0)
            {
                WriteLine("\n\nThere are no employees to view yet.\n");
            }
            else
            {
                Clear();
                WriteLine("Employees List:\n");
                for (int i = 0; i < employees.Count; i++)
                {
                    WriteLine(employees[i].GetEmployeeInfo());
                }
            }
        }


        private static void AddEmployeeCheck()
        {
            if (employees.Count == 0)
            {
                HelperClass.PressAnyKey("There are no employees to add checks to. Press any key to continue.");
            }
            else
            {
                int choice = 0;
                Clear();
                ViewAllEmployees();
                choice = HelperClass.GetInteger("Enter id of Employee to add a check to: ");
                if ((choice <= 0) || (choice > students.Count))
                {
                    HelperClass.PressAnyKey("That is not a valid employee ID, Press any key to continue.");
                }
                else
                {
                    Decimal check = HelperClass.GetDecimal("Enter the check to add: ");
                    string message = "";
                    if (check < 0)
                    {
                        message += "That check is less than zero and cannot be added. ";
                    }
                    else
                    {
                        employees[choice - 1].AddCheck(check);
                        message += "That check in the amount of " + check + " has been added.";
                    }
                    HelperClass.PressAnyKey(message + " Press any key to continue.");
                }
            }
        }

        static void Main(string[] args)
        {
            int choice = 0;
            String menu = "Student Entry System\n\nMain Menu\n"
                + "\t1) Add a student\n"
                + "\t2) View all students\n"
                + "\t3) Add a grade for a student\n"
                + "\t4) Clear students\n"
                + "\t5) Add an employee\n"
                + "\t6) View all employees\n"
                + "\t7) Add a check for an employee\n"
                + "\t8) Clear employees\n"
                + "\t9) Exit\n"
                + "\nMake a selection: ";
            do
            {
                Clear();
                choice = HelperClass.GetInteger(menu);
                switch (choice)
                {
                    case 1: //Add a student
                        AddStudent();
                        break;
                    case 2: //View all students
                        ViewAllStudents();
                        HelperClass.PressAnyKey("Press any key to continue.");
                        break;
                    case 3: //Add a grade
                        AddStudentGrade();
                        break;
                    case 4: //Clear students
                        if (students.Count == 0)
                        {
                            WriteLine("\nThe Student's list is already empty.");
                        }
                        else
                        {
                            students.Clear();
                            WriteLine("\nStudent's list has been cleared.");
                        }
                        HelperClass.PressAnyKey("Press any key to continue.");
                        break;
                    case 5: //Add an employee
                        AddEmployee();
                        break;
                    case 6: //View all employees
                        ViewAllEmployees();
                        HelperClass.PressAnyKey("Press any key to continue.");
                        break;
                    case 7: //Add a check
                        AddEmployeeCheck();
                        break;
                    case 8: //Clear employees
                        if (employees.Count == 0)
                        {
                            WriteLine("\nThe Employee's list is already empty.");
                        }
                        else
                        {
                            employees.Clear();
                            WriteLine("\nEmployee's list has been cleared.");
                        }
                        HelperClass.PressAnyKey("Press any key to continue.");
                        break;
                    case 9: //Exit
                        HelperClass.PressAnyKey("Okay, Goodbye!!! Press any key to end");
                        break;
                    default:
                        HelperClass.PressAnyKey("That is not a valid selection!!! Press any key to end");
                        break;
                }
            } while (choice != 9);
        }
    }
}
