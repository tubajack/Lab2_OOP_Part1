using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_C_Sharp_OOP
{
    class BusinessEmployee : Employee
    {
        public double BonusBudget = 1000; 

        //Call upon the base-class(Employee) constructor from
        //derived class (BusinessEmployee)
        //Set base salary to 50000 for BusinessEmployee object
        public BusinessEmployee(String name) : base(name, 50000){

        }

        //Return the employee ID number. Print the bonus budget
        public override string employeeStatus()
        {
            return toString() + " has a budget of " +
                this.BonusBudget;
        }
    }
}
