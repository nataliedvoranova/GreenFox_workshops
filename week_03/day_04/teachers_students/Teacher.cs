using System;
using System.Collections.Generic;
using System.Text;

namespace teachers_students
{
    /*Teacher
            Teach(student) -> calls the students learn method
            Answer() -> prints the teacher is answering a question*/
    class Teacher
    {
        public string Name { get; set; }
        public Teacher (string name)
        {
            Name = name;
        }
        public void Teach (Student student, string teachWhat)
        {
            Console.WriteLine($"{Name} is teaching {student.Name} {teachWhat}");
            student.Learn(teachWhat);
        }
        public void Answer(string answer, Student student)
        {
            
            Console.WriteLine($"{Name} answers {answer} to {student.Name}");
        }
    }
}
