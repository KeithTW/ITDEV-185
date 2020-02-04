using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_1
{
    class Output
    {
        public void Test()
        {
            using (StreamWriter write = new StreamWriter("output.txt", true))
            {
                write.WriteLine("Test");

            }

        }

        public void Update(List<Employee> employees, List<Student> students)
        {
            System.IO.File.WriteAllText("output.txt", "");

            using (StreamWriter write = new StreamWriter("output.txt", true))
            {
                write.WriteLine("[Employees]");
                foreach (Employee e in employees)
                {
                    write.WriteLine(e.ToString());

                }

                write.WriteLine("[Students]");
                foreach (Student s in students)
                {
                    write.WriteLine(s.ToString());

                }

            }

            Console.WriteLine("Exported successfully");

        }

        public void Read()
        {
            String[] lines = System.IO.File.ReadAllLines("input.txt");
            int type = 0;

            List<Employee> es = new List<Employee>();
            List<Student> ss = new List<Student>();

            foreach (String line in lines)
            {
                if(line[0] == '[')
                {
                    if (line[1] == 'E')
                    {
                        type = 1;

                    } else
                    {
                        type = 2;

                    }

                } else
                {
                    String[] split = line.Split(" - ");

                    switch (type)
                    {
                        case 1:
                            Employee tempE = new Employee(
                                split[0],
                                split[1],
                                split[2]
                                );

                            es.Add(tempE);

                            break;

                        case 2:
                            Student tempS = new Student(
                                split[0],
                                split[1],
                                int.Parse(split[2]),
                                split[3].Split(", ")
                                );

                            ss.Add(tempS);

                            break;

                    }


                }

            }

            Console.WriteLine("File Employees");
            foreach (Employee e in es)
            {
                Console.WriteLine(e.ToString());

            }

            Console.WriteLine("File Students");
            foreach (Student s in ss)
            {
                Console.WriteLine(s.ToString());

            }

            Console.WriteLine("Read successfully");

        }


    }
}
