using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Vaibhav" },
                new Employee {ID = 102, Name = "UserOne" },
                new Employee {ID = 103, Name = "UserTwo" },
            };

            //Create a instance of delegate
            Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployees);

            // Pass the value to instance of delegate
            Employee employee =  listEmployees.Find(emp => FindEmployees(emp));
            if (employee != null)
            {
                Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
                Console.ReadLine();
            }

            Console.WriteLine("You got a null object");
            Console.ReadLine();

        }

        public static  bool FindEmployees(Employee emp)
        {
            return emp.ID == 102;
         }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
