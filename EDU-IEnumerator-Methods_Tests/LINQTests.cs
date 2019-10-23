using EDU_IEnumerator_Methods.Models;
using EDU_IEnumerator_Methods.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EDU_IEnumerator_Methods_Tests
{
    [TestClass()]
    public class LINQTests
    {
        IEnumerable<Employee> employees;

        [TestInitialize]
        public void TestInit()
        {
            employees = EmployeeTestData.GetListOf10Employees();
        }

        [TestMethod()]
        public void Filtering_By_Salary()
        {
            IEnumerable<Employee> selected =
                from employee in employees
                where employee.Salary > 80000
                select employee;

            Assert.AreEqual(4, selected.Count());
        }

        [TestMethod()]
        public void Filtering_By_Position()
        {
            IEnumerable<Employee> selected =
                from employee in employees
                where employee.Position.Equals("Engineer")
                select employee;
            
            Assert.AreEqual(5, selected.Count());
        }

        [TestMethod()]
        public void Projecting_To_Names()
        {
            IEnumerable<string> names =
                from employee in employees
                select employee.FirstName + " " + employee.LastName;
            
            foreach(string name in names)
            {
                Trace.WriteLine(name);
            }

            Assert.AreEqual(10, names.Count());
        }

        [TestMethod()]
        public void Projecting_To_AnonymousType()
        {
            var salariesMap =
                from employee in employees
                select new
                {
                    Name = employee.FirstName + " " + employee.LastName,
                    Salary = employee.Salary
                };

            foreach (var salary in salariesMap)
            {
                Trace.WriteLine(salary.Name + ": " + salary.Salary);
            }

            Assert.AreEqual(10, salariesMap.Count());
        }

        [TestMethod()]
        public void Projecting_To_Number_Via_Func()
        {
            double totalSalaryPerHour = 0;

            System.Func<Employee, double> calcSalaryPerHour =
                employee =>
                {
                    // 2,080 hours in a typical work year
                    double salaryPerHour = employee.Salary / 2080;
                    Trace.WriteLine(employee.FirstName + employee.LastName + ": " + salaryPerHour);

                    totalSalaryPerHour += salaryPerHour;

                    return salaryPerHour;
                };

            IEnumerable<double> salaries =
                from employee in employees
                select calcSalaryPerHour(employee);

            double averageSalary = salaries.Average();

            Assert.AreEqual(36, averageSalary);
            Assert.AreEqual(360, totalSalaryPerHour);
        }

        [TestMethod()]
        public void Sorting_By_Salary()
        {
            IEnumerable<long> orderedSalaries =
                from employee in employees
                orderby employee.Salary descending
                select employee.Salary;

            Assert.AreEqual(94000, orderedSalaries.First());
        }

        [TestMethod()]
        public void Grouping_By_Position()
        {
            IEnumerable<IGrouping<string, long>> salariesGroups =
                from employee in employees
                group employee.Salary by employee.Position;

            foreach(IGrouping<string, long> salariesGroup in salariesGroups)
            {
                Trace.Write("position: " + salariesGroup.Key + "; ");

                foreach(long salary in salariesGroup)
                {
                    Trace.Write(salary + ", ");
                }
                Trace.WriteLine("");
            }

            Assert.AreEqual(3, salariesGroups.Count());
        }
    }
}
