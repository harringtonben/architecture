﻿using System;


namespace architecture.Departments
{
    class IT : Department
    {
        public string TechStack { get; set; }
        public bool AreLazy { get; set; }

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
    }
}