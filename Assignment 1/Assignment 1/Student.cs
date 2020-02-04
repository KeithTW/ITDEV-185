using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Student : Person
    {
        int StudentIDNum;
        String[] classList;

        public Student(int StudentID, String[] ClassList)
        {
            FName = "Default FName";
            LName = "Default LName";

            StudentIDNum = StudentID;

            classList = ClassList;

        }

        public Student(String tFName, String tLName, int StudentID, String[] ClassList)
        {
            FName = tFName;
            LName = tLName;

            StudentIDNum = StudentID;

            classList = ClassList;

        }

        public override string ToString()
        {
            String returnString;

            returnString = FName + " " + LName + " - " + StudentIDNum + " - ";

            foreach(String s in classList)
            {
                returnString += s + " | ";

            }

            return returnString;

        }

    }

}
