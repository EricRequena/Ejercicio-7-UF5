using System;

namespace OOPVisita
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Code { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hiredate { get; set; }
        public float MonthlySalary { get; set; }
        public int Payments { get; set; }
        private static int employeeCount = 0;

        public Employee(string name, DateTime dateOfBirth, string code, DateTime birthdate, DateTime hiredate)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Code = code;
            Birthdate = birthdate;
            Hiredate = hiredate;
            MonthlySalary = 1800;
            Payments = 14;
            employeeCount++;

        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;


            if (DateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }

        public int Antiquity()
        {
            DateTime today = DateTime.Today;
            int antiquity = today.Year - Hiredate.Year;

            if (Hiredate.Date > today.AddYears(-antiquity))
                antiquity--;
                antiquity = antiquity * -1;

            return antiquity;
        }

        public override string ToString()
        {
            return $"Nom: {Name}, Edad: {CalculateAge()}, Salari Antiguitat: {Antiquity()} Salary actual:{MonthlySalary * Payments}";
        }

        public static int EmployeeCount()
        {
            return employeeCount;
        }
    }

}
