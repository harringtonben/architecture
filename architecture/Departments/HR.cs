using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture.Departments
{
    class HR : Department
    {
        public int Rules { get; set; }
        public int Grievances { get; set; }

        public void ImInTrouble()
        {
            Console.WriteLine($"The {GetType().Name} department has filed {Grievances} against me because I have broken {Rules} rules.");
        }
    }
}
