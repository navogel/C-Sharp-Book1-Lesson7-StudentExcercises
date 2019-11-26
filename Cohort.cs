using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {

        //constructor-bot
        public Cohort(string name)
        {
            Name = name;
        }

        //properties
        public string Name { get; set; }

        public List<Student> StudentsInCohort = new List<Student>();
        public List<Instructor> InstructorsInCohort = new List<Instructor>();

        public Student AddNewStudent(string firsty, string lasty, string slacky) 
        {
        var student = new Student(firsty, lasty, slacky, this);
        StudentsInCohort.Add(student);
        return student;

        }

        public Instructor AddNewInstructor(string firsty, string lasty, string slacky, string specialty) 
        {
        var instructor = new Instructor(firsty, lasty, slacky, specialty, this);
        InstructorsInCohort.Add(instructor);
        return instructor;
        }

        public void AssignExercise(Exercise exercise)
        {
            foreach (var student in StudentsInCohort)
            {
                student.StudentsExercises.Add(exercise);
            }
        }
    }

}