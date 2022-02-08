using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ClassObjectsDemo
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }
    class linq
    {
        public void Employee()
        {
            string[] names = { "Ramesh", "Sibin", "Akil", "James", "Mohan" };

            var query = from name in names where name.Contains("a") select name;

            foreach (var name in query)
            {
                Console.Write($"{name} ,");
            }
            Console.WriteLine(" ");

            IList<Student> students = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "Immanuel", Age = 14} ,
        new Student() { StudentID = 2, StudentName = "Robinson",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Edward",  Age = 17 } ,
        new Student() { StudentID = 4, StudentName = "Thulasi" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Krishnan" , Age = 22 },
        new Student() { StudentID = 6, StudentName = "Samraj" , Age = 18 },
        new Student() { StudentID = 7, StudentName = "Vikram" , Age = 13 },
        new Student() { StudentID = 7, StudentName = "Ravi" , Age = 16 },
        new Student() { StudentID = 9, StudentName = "Arjun" , Age = 23 }

    };
            var teenAgerStudent = from s in students where s.Age > 12 && s.Age < 20 select s;
            Console.WriteLine("Teen age Students:");
            foreach (Student std in teenAgerStudent)
            {
                Console.Write(std.StudentName + "  ,");
                
            }
            Console.WriteLine(" ");
            var major = students.Where(s => s.Age >=18 );

            Console.WriteLine("Major Students:");

            foreach (Student std in major)
            {
                Console.Write(std.StudentName+" ,");
            }
            Console.WriteLine(" ");

            var orderByDescendingResult = from s in students orderby s.StudentName select s;
            Console.WriteLine("Ascending order by name:");

            foreach (Student std in orderByDescendingResult)
            {
                Console.Write(std.StudentName + " ,");
            }
            Console.WriteLine(" ");
        }
    }
}
