using EDU_IEnumerator_Methods.Models;
using EDU_IEnumerator_Methods.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EDU_IEnumerator_Methods.Tests
{
    [TestClass()]
    public class IEnumerableTests
    {
        IEnumerable<Employee> employees;
        
        [TestInitialize]
        public void TestInit()
        {
            employees = EmployeeTestData.GetListOf10Employees();
        }

        [TestMethod()]
        public void Where_3RecordsStartsWithK_Returns3Records()
        {
            employees = employees.Where(employee => employee.FirstName.StartsWith("K"));
            
            Assert.AreEqual(3, employees.Count());
        }

        [TestMethod()]
        public void Where_5EmployeesEarnMoreThan80000_Returns5Records()
        {
            employees = employees.Where(employee => employee.Salary > 80000);
            
            Assert.AreEqual(4, employees.Count());
        }

        [TestMethod()]
        public void Select_TotalSalaryForEngineersIs369000()
        {
            long totalSalaryForEngineers = employees
                .Where(employee => employee.Position.Equals("Engineer"))
                .Select(employee => employee.Salary)
                .Sum();

            Assert.AreEqual(369000, totalSalaryForEngineers);
        }

        [TestMethod()]  
        public void OrderBy_NameOfMostValuableQAIsVan()
        {
            string qaMvpFirstName = employees
                .OrderBy(employee => employee.Salary)
                .Where(employee => employee.Position.Equals("QA"))
                .First()
                .FirstName;

            Assert.AreEqual("Van", qaMvpFirstName);
        }
    }
}
