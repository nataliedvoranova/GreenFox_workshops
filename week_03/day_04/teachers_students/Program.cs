using System;

namespace teachers_students
{
    class Program
    {
        /*Create Student and Teacher classes
        Student
        Learn() -> prints the student is learning something new
        Question(teacher) -> calls the teachers answer method
        Teacher
        Teach(student) -> calls the students learn method
        Answer() -> prints the teacher is answering a question
        Instantiate a Student and Teacher object
        Call the student's Question() method and the teacher's Teach() method*/
        static void Main(string[] args)
        {
            Student student = new Student("Mike");
            Teacher teacher = new Teacher("Mr.Anderson");

            student.Question("what 2+2 equals?", teacher);
            teacher.Answer("4", student);
            teacher.Teach(student, "maths");
            
        }
    }
}
