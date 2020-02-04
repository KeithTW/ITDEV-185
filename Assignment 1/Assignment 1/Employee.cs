using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Employee : Person
    {
        String EmployeeIDNum;

        public Employee(String EmployeeID)
        {
            FName = "Default FName";
            LName = "Default LName";

            EmployeeIDNum = EmployeeID;

        }

        public Employee(String tFName, String tLName, String EmployeeID)
        {
            FName = tFName;
            LName = tLName;

            EmployeeIDNum = EmployeeID;

        }

        public override string ToString()
        {
            return FName + " " + LName + " - " + EmployeeIDNum;

        }

    }

}
