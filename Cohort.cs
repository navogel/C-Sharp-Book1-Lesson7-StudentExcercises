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

        public void AddNewStudent(string firsty, string lasty, string slacky, List<Student> allStudents) 
        {
        StudentsInCohort.Add(new Student(firsty, lasty, slacky, this, allStudents));
        }

        public void AddNewInstructor(string firsty, string lasty, string slacky, string specialty) 
        {
        InstructorsInCohort.Add(new Instructor(firsty, lasty, slacky, specialty, this));
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