using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_C_Sharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate first employee object employee1
            var employee1 = new Employee("Libby", 2000);
            //Second employee- employee2- Technical
            var employee2 = new TechnicalEmployee("Evan");
            //Third employee- employee3- Business
            var employee3 = new BusinessEmployee("Max");

            //Output to the console window
            Console.WriteLine(employee1.employeeStatus());
            Console.WriteLine(employee2.employeeStatus());
            Console.WriteLine(employee3.employeeStatus());
        }
    }
}
