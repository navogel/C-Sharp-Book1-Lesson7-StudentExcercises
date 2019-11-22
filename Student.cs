using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {

        public Student(string firsty, string lasty, string slacky, Cohort cohorty)
        {
            FirstName = firsty;
            LastName = lasty;
            SlackHandle = slacky;
            StudentCohort = cohorty;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort StudentCohort { get; set; }



        //collection of excercises
        public List<Excercise> StudentsExcercises = new List<Excercise>();
    }

}