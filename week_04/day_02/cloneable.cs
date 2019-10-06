using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    /*public interface ICloneable
    {
        void Clone();
    }*/
    class Person
    {/*
        private string name;
        private int age;
        private string gender;*/

        public string Name { get; set; } = "Jane Doe";
        public int Age { get; set; } = 30;
        public string Gender { get; set; } = "female";

        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }



        public virtual void Introduce()
        {
            Console.WriteLine(" Hi, I am " + Name + " " + Age + " years old " + Gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }

    class Student : Person, ICloneable
    {
        public object Clone()
        {
            //return this.MemberwiseClone();
            return new Student(this.Name, this.Age, this.Gender, this.PreviousOrganisation);
        }

        public string PreviousOrganisation { get; set; }

        public int SkippedDays { get; set; }


        public Student(string name = "Jane Doe", int age = 30, string gender = "female", string previousOrganisation = " School Of Life") : base(name, age, gender)
        {
            this.PreviousOrganisation = previousOrganisation;
            SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine(" Hi, I am " + Name + " " + Age + " years old " + Gender + " from " + PreviousOrganisation + " who skipped " + SkippedDays + " days from the course already.");
        }

        //SkipDays(numberOfDays): increases skippedDays by numberOfDays
        public void SkipDays(int numbersOfDays)
        {
            SkippedDays += numbersOfDays;
        }
    }

    class Mentor : Person
    {
        public string Level { get; set; }
        public Mentor(string name = "Jane Doe", int age = 30, string gender = "female", string level = "intermediate") : base(name, age, gender)
        {
            this.Level = level;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine(" Hi, I am " + Name + " " + Age + " years old " + Gender + " " + Level + " mentor.");
        }

    }

    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }
        public Sponsor(string name = "Jane Doe", int age = 30, string gender = "female", string company = "Google") : base(name, age, gender)
        {
            this.Company = company;
            HiredStudents = 0;
        }
        public void Hire()
        {
            HiredStudents++;
        }

        public override void Introduce()
        {
            Console.WriteLine(" Hi, I am " + Name + " " + Age + " years old " + Gender + " " + Company + " " + HiredStudents);
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        class Cohort
        {
            public string Name { get; set; }
            public List<Student> listOfStudents { get; set; }
            public List<Mentor> listOfMentors { get; set; }

            public Cohort(string name)
            {
                this.Name = name;
                listOfStudents = new List<Student>();
                listOfMentors = new List<Mentor>();
            }

            public void AddStudent(Student student)
            {
                listOfStudents.Add(student);
            }

            public void AddMentor(Mentor mentor)
            {
                listOfMentors.Add(mentor);
            }

            public void Info()
            {
                Console.WriteLine("The " + Name + " cohort has " + listOfStudents.Count + " students and " + listOfMentors.Count + " mentors.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                /*Person personOne = new Person();
                personOne.Introduce();

                Student student = new Student("Jane Doe", 30, "female", "The School of Life");
                student.Introduce();

                Mentor mentor = new Mentor("Jane Doe", 30, "female", "intermediate");
                mentor.Introduce();

                Sponsor sponsor = new Sponsor("Jane Doe", 30, "female", "Google");
                sponsor.Introduce();*/

                var people = new List<Person>();

              /*  var mark = new Person("Mark", 46, "male");
                people.Add(mark);
                var jane = new Person();
                people.Add(jane);*/

                var john = new Student("John Doe", 20, "male", "BME");
                people.Add(john);
                john.Introduce();
                Student johnTheClone = (Student)john.Clone();
                johnTheClone.Introduce();

/*
                var studentTwo = new Student();
                people.Add(student);
                var gandhi = new Mentor("Gandhi", 148, "male", "senior");
                people.Add(gandhi);
                var mentorTwo = new Mentor();
                people.Add(mentor);
                var sponsorTwo = new Sponsor();
                people.Add(sponsor);
                var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
                people.Add(elon);



                student.SkipDays(3);

                for (int i = 0; i < 5; i++)
                {
                    elon.Hire();
                }

                for (int i = 0; i < 3; i++)
                {
                    sponsor.Hire();
                }

                foreach (var person in people)
                {
                    person.Introduce();
                    person.GetGoal();
                }

                Cohort awesome = new Cohort("AWESOME");
                awesome.AddStudent(student);
                awesome.AddStudent(john);
                awesome.AddMentor(mentor);
                awesome.AddMentor(gandhi);
                awesome.Info();*/
            }
        }
    }
}
