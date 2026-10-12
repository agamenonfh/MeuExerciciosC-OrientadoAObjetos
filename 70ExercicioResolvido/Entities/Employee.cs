using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Course.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        override public string ToString()
        {
            return $"{Name} - $ {Payment():F2}";
        }
    }
}
