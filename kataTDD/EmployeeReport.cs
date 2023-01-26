using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataTDD
{
    public class EmployeeReport
    {
        private static IEnumerable<Employee> Employees
        {
            get
            {
                yield return new Employee() { Name = "Empl 1", Age = 21 };
                yield return new Employee() { Name = "Empl 2", Age = 18 };
                yield return new Employee() { Name = "Empl 3", Age = 46 };
                yield return new Employee() { Name = "Empl 4", Age = 14 };
                yield return new Employee() { Name = "Empl 5", Age = 17 };
            }
        }

        public static List<Employee> GetEmployees()
        {
            return Employees.Where(e => e.Age >= 18).ToList();
        }
    }
}
