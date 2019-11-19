using System;
using System.Collections.Generic;
// this is for bringing Ilist object
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_38
{
    public delegate bool Ispromotoable(Employee emp); 
    class Program
    {
        //the whole purpose is to implement generic PROMOTE Employe method that can be resued again and again
        // this can be achieved by Delegates
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 101, Name = "John", Salary = 5000, Experience = 4 });
            employees.Add(new Employee { Id = 102, Name = "Mary", Salary = 10000, Experience = 9 });
            employees.Add(new Employee { Id = 103, Name = "Walid", Salary = 8000, Experience = 6 });
            employees.Add(new Employee { Id = 104, Name = "Ola", Salary = 2000, Experience = 1 });


            // this is way number one to call the method(Employee.PromoteEmployee)
            Ispromotoable isPromoted = new Ispromotoable(Promote);
            Employee.PromoteEmployee(employees,isPromoted);


            // Another way to call the method(Employee.PromoteEmployee) by using LAMBDA expression
            // in that case you do not need to implement (Promote method)
            Employee.PromoteEmployee(employees, x => x.Experience >5);

        }

        // you need to add/implement this method which contains the logic to decouble from class part
        public static bool Promote(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        // adding a function as parameter to the PromoteEmployee method
        public static void PromoteEmployee(IList<Employee> emloyeeList, Ispromotoable isEligible)
        {
            // this method need to be implemnted by Delegates
            foreach (Employee emp in emloyeeList)
            {
                // this method will pass to promote the employee based on logic "E.g. Employee experience greater than 5 years"
                // this will be passed by LAMDA expression or by calling a bool method which return true or false
                if (isEligible(emp))
                {
                    Console.WriteLine("Employee : {0} -- promoted", emp.Name);
                }
            }
        }
    }

}
