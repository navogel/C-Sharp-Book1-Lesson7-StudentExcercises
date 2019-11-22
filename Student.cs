using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {

        public Student(string firsty, string lasty, string slacky, Cohort cohorty, List<Student> allStudents)
        {
            FirstName = firsty;
            LastName = lasty;
            SlackHandle = slacky;
            StudentCohort = cohorty;
            allStudents.Add(this);

            return;
        }

       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort StudentCohort { get; set; }

        //collection of excercises
        public List<Exercise> StudentsExercises = new List<Exercise>();

    }

}