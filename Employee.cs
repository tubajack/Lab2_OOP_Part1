using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_C_Sharp_OOP
{
    class Employee
    {
        private static int EmployeeCount = 1; 

        private string EmployeeName;
        private double EmployeeBaseSalary;
        private int EmployeeID;

        public string Name{
            get{
                return EmployeeName;
            }
            set{
                EmployeeName = value; 
            }
        }

        public double BaseSalary{
            get{
                return EmployeeBaseSalary;
            }
            set{
                EmployeeBaseSalary = value;
            }
        }

        public int ID{
            get{
                return EmployeeID;
            }
            set{
                EmployeeID = value; 
            }
        }

        public double getBaseSalary(){
            return this.BaseSalary;
        }

        public String getName(){
            return this.Name;
        }

        public int getEmployeeID(){
            return this.ID;
        }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = EmployeeCount++;
        }

        //Return ID and name
        public String toString(){
            return this.ID + " " + this.Name;
        }

        //Confirm that the employee is in the system
        public virtual String employeeStatus(){
            return toString() + " is in the company's system";
        }

    }
}
