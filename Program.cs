using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

                        // public class Company
            

                // public string Name { get; }
                // public DateTime CreatedOn { get; }

                // Create a property for holding a list of current employees

                Company company = new Company ("LilCakes", DateTime.Now);

                // I know it said to add 3 but I wanted four!

                Employee employee1 = new Employee ("Lorie", "Baker", "June 14, 2010");
                Employee employee2 = new Employee ("Brandie", "Designer", "September 22, 2011");
                Employee employee3 = new Employee ("Bridgette", "Cashier", "Febuary 5, 2011");
                Employee employee4 = new Employee ("Liz", "Everything", "October 22, 2010");

                company.addEmployee(employee1);
                company.addEmployee(employee2);
                company.addEmployee(employee3);
                company.addEmployee(employee4);

                company.ListEmployees();
        }
            
        }
                public class Company
                {

                 /*
                    Some read only properties
                */

                    public string Name { get; }
                    public DateTime CreatedOn { get; }

                    public List<Employee> listOfEmployees = new List <Employee>();

                    public void addEmployee (Employee employee)
                    {
                        listOfEmployees.Add(employee);
                    }

                    public void removeEmployee (Employee employee)
                    {
                        listOfEmployees.Remove(employee);
                    }

                    public Company (string name, DateTime createdOn)
                    {
                        Name = name;
                        CreatedOn = createdOn;
                    }

                    public void ListEmployees()
                        {
                            foreach (Employee empl in listOfEmployees)
                            {
                                Console.WriteLine ($"{empl.Name}, {empl.JobTitle}, {empl.StartDate}");
                            }
                        }
                }

                public class Employee
                {
                    public string Name;
                    public string JobTitle;
                    public string StartDate;

                    public Employee (string name, string jobTitle, string startDate)
                    {
                        Name = name;
                        JobTitle = jobTitle;
                        StartDate = startDate;
                    }
                }
    }

                // Create a method that allows external code to add an employee

                // Create a method that allows external code to remove an employee

                /*
                    Create a constructor method that accepts two arguments:
                        1. The name of the company
                        2. The date it was created

                    The constructor will set the value of the public properties
                */
 

