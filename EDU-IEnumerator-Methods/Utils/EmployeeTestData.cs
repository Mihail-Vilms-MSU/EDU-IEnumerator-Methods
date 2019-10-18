using EDU_IEnumerator_Methods.Models;
using System;
using System.Collections.Generic;

namespace EDU_IEnumerator_Methods.Utils
{
    public class EmployeeTestData
    {
        public static List<Employee> GetListOf10Employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 10001,
                    FirstName = "Evelyn",
                    LastName = "Friedman",
                    Position = "Engineer",
                    Salary = 50000,
                    BirthDate =  new DateTime(1990, 03, 04)
                },
                new Employee()
                {
                    Id = 10002,
                    FirstName = "Van",
                    LastName = "Anthony",
                    Position = "QA",
                    Salary = 60000,
                    BirthDate =  new DateTime(1992, 10, 06)
                },
                new Employee()
                {
                    Id = 10003,
                    FirstName = "Drew",
                    LastName = "Strickland",
                    Position = "Engineer",
                    Salary = 70000,
                    BirthDate =  new DateTime(1987, 01, 01)
                },
                new Employee()
                {
                    Id = 10004,
                    FirstName = "Sonny",
                    LastName = "Zimmerman",
                    Position = "PM",
                    Salary = 80000,
                    BirthDate =  new DateTime(1986, 03, 03)
                },
                new Employee()
                {
                    Id = 10005,
                    FirstName = "Kailey",
                    LastName = "Rush",
                    Position = "Engineer",
                    Salary = 90000,
                    BirthDate =  new DateTime(1981, 10, 10)
                },
                new Employee()
                {
                    Id = 10006,
                    FirstName = "Kenna",
                    LastName = "Downs",
                    Position = "QA",
                    Salary = 85000,
                    BirthDate =  new DateTime(1984, 7, 2)
                },
                new Employee()
                {
                    Id = 10007,
                    FirstName = "Kaila ",
                    LastName = "Beard",
                    Position = "PM",
                    Salary = 74000,
                    BirthDate =  new DateTime(1974, 2, 10)
                },
                new Employee()
                {
                    Id = 10008,
                    FirstName = "Jett",
                    LastName = "Wood",
                    Position = "Engineer",
                    Salary = 94000,
                    BirthDate =  new DateTime(1987, 4, 8)
                },
                new Employee()
                {
                    Id = 10009,
                    FirstName = "Mauricio",
                    LastName = "West",
                    Position = "Engineer",
                    Salary = 65000,
                    BirthDate =  new DateTime(1989, 9, 11)
                },
                new Employee()
                {
                    Id = 100010,
                    FirstName = "Neil",
                    LastName = "Everett",
                    Position = "QA",
                    Salary = 91000,
                    BirthDate =  new DateTime(1993, 2, 10)
                },
            };
        }
    }
}
