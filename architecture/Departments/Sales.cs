using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architecture.Departments
{
    class Sales : Department
    {
        public int NumberOfDeals { get; set; }
        public bool AreTools { get; set; }

        public void SalesGoals()
        {
            if (AreTools)
            {
                Console.WriteLine($"Our sales guys have closed {NumberOfDeals} deals this year, but man are they tools.");
            }
            else
            {
                Console.WriteLine($"Our sales guys have closed {NumberOfDeals} deals this year, and they are actually pretty alright.");
            }

        }

        public override void Deparment_Description()
        {
            NumberOfDeals += 15;
            base.Deparment_Description();
        }

        public override void SetBudget(double budget)
        {
            Budget = budget + 20000;
            Console.WriteLine($"The budget for this depratment is {Budget}");
        }
    }
}
