using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVisita
{
    public class SalesEmployee : Employee
    { 
        private float commission;

        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public SalesEmployee(string name, DateTime dateOfBirth, float commission, string code, DateTime birthdate, DateTime hiredate) : base(name, dateOfBirth, code, birthdate, hiredate)
        {
            Commission = commission;
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
                antiquity= antiquity * -1;

            return antiquity;
        }

        public override string ToString()
        {
            return $"Nom: {Name}, Edad: {CalculateAge()}, Salari mAntiguitat: {Antiquity()} Salary actual:{MonthlySalary * Payments}";
        }
    }
}
