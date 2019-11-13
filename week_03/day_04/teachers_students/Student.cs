using System;
using System.Collections.Generic;
using System.Text;

namespace teachers_students
{
    /*Student
            Learn() -> prints the student is learning something new
            Question(teacher) -> calls the teachers answer method*/
    class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public void Learn(string newThing)
        {
            Console.WriteLine("Student " +Name+ " is learning " + newThing);
        }
        public void Question (String question, Teacher teacher)
        {
            Console.WriteLine($"Student asks {teacher.Name} {question}");
        }
    }
}
