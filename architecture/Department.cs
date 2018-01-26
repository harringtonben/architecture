using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture
{
    class Department
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public int Employee_Count { get; set; }

        public void Deparment_Description()
        {
            Console.WriteLine($"{Name} is overseen by {Supervisor} and has {Employee_Count} number of employees.");
        }
    }
}
