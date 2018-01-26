using architecture.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
        }
    }
}
