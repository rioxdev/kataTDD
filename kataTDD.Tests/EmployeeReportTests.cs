using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataTDD.Tests;

public class EmployeeReportTests
{
    private List<Employee> _employees;

    public EmployeeReportTests()
    {
        _employees = new List<Employee>()
        {
            new Employee()
            {
                Name = "Empl 1", Age = 21
            },

            new Employee()
            {
                Name = "Empl 2", Age = 18
            },

            new Employee()
            {
                Name = "Empl 3", Age = 46
            }
        };
    }


    [Fact]
    public void RepportShouldReturn18Ages()
    {
        var result = EmployeeReport.GetEmployees();

        result.Should().Equal(_employees, (e1, e2) => e1.Age == e2.Age && e1.Name == e2.Name );
    }
}
