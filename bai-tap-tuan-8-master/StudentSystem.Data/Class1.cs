using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    class Class1
    {
        // This is a placeholder class for the StudentSystem project.
        // You can add properties and methods here as needed.
        public string Name { get; set; }
        public int Age { get; set; }
        public Class1(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
