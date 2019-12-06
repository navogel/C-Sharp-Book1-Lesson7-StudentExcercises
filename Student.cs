using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {

        public Student(string firsty, string lasty, string slacky, Cohort cohorty)
        {
            FirstName = firsty;
            LastName = lasty;
            SlackHandle = slacky;
            StudentCohort = cohorty;
            
        }

       
       
        public Cohort StudentCohort { get; set; }

        //collection of excercises
        public List<Exercise> StudentsExercises = new List<Exercise>();

    }

}