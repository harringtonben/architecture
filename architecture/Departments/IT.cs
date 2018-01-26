using System;


namespace architecture.Departments
{
    class IT : Department, ISecurity
    {
        public string TechStack { get; set; }
        public bool AreLazy { get; set; }
        public bool SecurityClearance { get; set; }

        public void IsCleared()
        {
            if (SecurityClearance)
            {
                Console.WriteLine($"People on this team are allowed to write to the database because their security clearance gives them access to.");
            }
        }

        public void OurDevelopers()
        {
            if (AreLazy)
            {
                Console.WriteLine($"Our developers all code in {TechStack} but they are lazy as hell.");
            }
            else
            {
                Console.WriteLine($"Our developers all code in {TechStack} and they rock the cazba!");
            }
        }

        public override void SetBudget(double budget)
        {
            Budget = budget + 6000;
            Console.WriteLine($"The budget for this depratment is {Budget}");
        }
    }
}
