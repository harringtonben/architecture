using architecture.Departments;
using System;
using System.Collections.Generic;


namespace architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new Sales
            {
                Name = "Sales",
                Supervisor = "Joey",
                Employee_Count = 13,
                NumberOfDeals = 50,
                AreTools = false
            };

            var developers = new IT
            {
                Name = "Engineering",
                Supervisor = "Jason",
                Employee_Count = 11,
                TechStack = "Python/React",
                AreLazy = false
            };

            var humanresources = new HR
            {
                Name = "Human Resources",
                Supervisor = "Christine",
                Employee_Count = 3,
                Grievances = 4,
                Rules = 15
            };

            var support = new BasicDepartment
            {
                Name = "Support",
                Supervisor = "Benton",
                Employee_Count = 16
            };

            var marketing = new BasicDepartment
            {
                Name = "Marketing",
                Supervisor = "Colby",
                Employee_Count = 16
            };

            var Departments = new List<Department>
            {
                sales,
                developers,
                humanresources,
                support,
                marketing
            };

            foreach (var department in Departments)
            {
                department.Deparment_Description();
                department.SetBudget(75000);

                switch (department)
                {
                    case Sales s:
                        s.SalesGoals();
                        break;
                    case HR h:
                        h.ImInTrouble();
                        break;
                    case IT i:
                        i.OurDevelopers();
                        break;
                }
            }

            Console.Read();
        }
    }
}
