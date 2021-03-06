﻿using System;
using System.Collections.Generic;

namespace architecture.Departments
{
    abstract class Department
    {
        List<Employee> _employees = new List<Employee>();
        public List<Employee> Employees { get => _employees; }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public double Budget { get; set; }
        public int Employee_Count { get; set; }

        public virtual void Deparment_Description()
        {
            Console.WriteLine($"{Name} is overseen by {Supervisor} and has {Employee_Count} employees.");
        }

        public virtual void SetBudget(double budget)
        {
            Budget = budget;
            Console.WriteLine($"The budget for this depratment is {Budget}");
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

    }
}
