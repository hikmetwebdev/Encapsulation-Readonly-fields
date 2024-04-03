using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Readonly_fields.Modes
{
    public class Employee
    {
        private int employeeId;
        private string name;
        private string position;
        private decimal salary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative.");
            }
        }

        public Employee(int id, string name, string position, decimal salary)
        {
            EmployeeId = id;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
        }

        public void ChangePosition(string newPosition)
        {
            Position = newPosition;
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
