using System;
using System.Collections.Generic;
// this is for bringing Ilist object
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_37
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 101, Name = "John", Salary = 5000, Experience = 4 });
            employees.Add(new Employee { Id = 102, Name = "Mary", Salary = 10000, Experience = 9 });
            employees.Add(new Employee { Id = 103, Name = "Walid", Salary = 8000, Experience = 6 });
            employees.Add(new Employee { Id = 104, Name = "Ola", Salary = 2000, Experience = 1 });

          Employee.PromoteEmployee(employees);


        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(IList<Employee> emloyeeList)
        {
            foreach (Employee emp in emloyeeList)
            {
                // this method is hardcoded to promote the employee based on Employee experience greater than 5 years
                if (emp.Experience > 5)
                {
                    Console.WriteLine("Employee : {0} -- promoted",emp.Name);
                }
            }
        }
    }

}
