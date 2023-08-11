using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    
        public enum Gender
        {
            M,
            F,
        }
        public class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public decimal Salary { get; set; }
            public Gender Gender { get; set; }
            public int Age { get; set; }

            public void DisplayData()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Salary: " + Salary);
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("Age: " + Age);
            
        }
    }
}
