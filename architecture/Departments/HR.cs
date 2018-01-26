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
            Console.WriteLine($"The {GetType().Name} department has filed {Grievances} complaints against me because I have broken {Rules} rules.");
        }

        public override void Deparment_Description()
        {
            if (Grievances > 2)
            { 
                Console.WriteLine($"The {Name} department is always the most terrifying to have to visit. If you get a call from {Supervisor} it is not good for you");
                return;
            }
            base.Deparment_Description();
        }
    }
}
