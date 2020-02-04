using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Controller
    {
        public void Run()
        {
            Output otpt = new Output();

            List<Employee> employees = new List<Employee>();
            List<Student> students = new List<Student>();

            Employee emply1 = new Employee("1");
            Employee emply2 = new Employee("2");
            Employee emply3 = new Employee("3");
            Employee emply4 = new Employee("4");

            Student stdnt1 = new Student(1, new string[] { "Class 1", "Class 2" });
            Student stdnt2 = new Student(2, new string[] { "Class 2", "Class 3" });
            Student stdnt3 = new Student(3, new string[] { "Class 3", "Class 4" });
            Student stdnt4 = new Student(4, new string[] { "Class 4", "Class 1" });

            employees.Add(emply1);
            employees.Add(emply2);
            employees.Add(emply3);
            employees.Add(emply4);

            students.Add(stdnt1);
            students.Add(stdnt2);
            students.Add(stdnt3);
            students.Add(stdnt4);

            Console.WriteLine("Employees");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());

            }

            Console.WriteLine("Students");
            foreach (Student s in students)
            {
                Console.WriteLine(s.ToString());

            }

            otpt.Update(employees, students);
            otpt.Read();

        }

    }
}
