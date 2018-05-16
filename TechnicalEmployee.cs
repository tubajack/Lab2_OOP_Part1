using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_C_Sharp_OOP
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        //Call upon base-class (Employee Class) constructor from
        //within derived class (TechnicalEmployee Class)
        //Set the base salary to 75000 for TechnicalEmployees
        public TechnicalEmployee(String name) : base(name, 75000){

        }

        //Return toString method. Print the number of successful check ins
        public override string employeeStatus()
        {
            return this.toString() + " has " +
                this.successfulCheckIns + " successful check ins";
        }
    }
}
