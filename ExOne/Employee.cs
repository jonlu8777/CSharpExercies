using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOne
{
    internal class Employee
    {
        public int employeeID;
        public string employeeName;
        public double employeeWage;

        public Employee(int employeeID,string employeeName, double employeeWage)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeWage = employeeWage;
        }
    }
}
