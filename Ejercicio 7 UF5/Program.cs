using System;
using OOPVisita;

namespace OOPVista
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Pere", new DateTime(1980, 12, 12), "P001", new DateTime(1980, 12, 12), new DateTime(2010, 12, 12)),
                new Employee("Anna", new DateTime(1985, 12, 12), "A001", new DateTime(1985, 12, 12), new DateTime(2015, 12, 12)),
                new Employee("Pau", new DateTime(1990, 12, 12), "P002", new DateTime(1990, 12, 12), new DateTime(2020, 12, 12)),
                new Employee("Marta", new DateTime(1995, 12, 12), "M001", new DateTime(1995, 12, 12), new DateTime(2025, 12, 12)),
                new Employee("Joan", new DateTime(2000, 12, 12), "J001", new DateTime(2000, 12, 12), new DateTime(2030, 12, 12))
            };

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>
            {
                new SalesEmployee("Raul", new DateTime(1980, 12, 12), 0.1f, "P001", new DateTime(1980, 12, 12), new DateTime(2010, 12, 12)),
                new SalesEmployee("Marc", new DateTime(1985, 12, 12), 0.2f, "A001", new DateTime(1985, 12, 12), new DateTime(2015, 12, 12)),
                new SalesEmployee("Alberto", new DateTime(1990, 12, 12), 0.3f, "P002", new DateTime(1990, 12, 12), new DateTime(2020, 12, 12)),
                new SalesEmployee("Alex", new DateTime(1995, 12, 12), 0.4f, "M001", new DateTime(1995, 12, 12), new DateTime(2025, 12, 12)),
                new SalesEmployee("Joana", new DateTime(2000, 12, 12), 0.5f, "J001", new DateTime(2000, 12, 12), new DateTime(2030, 12, 12))
            };

            employees.Sort((x, y) => y.Hiredate.CompareTo(x.Hiredate));

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            foreach (SalesEmployee salesEmployee in salesEmployees)
            {
                Console.WriteLine(salesEmployee);
            }

            
        }
    }
}

