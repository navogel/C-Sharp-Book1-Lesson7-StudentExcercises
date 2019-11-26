using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public Instructor(string firsty, string lasty, string slacky, string specialty, Cohort cohorty )
        {
            FirstName = firsty;
            LastName = lasty;
            SlackHandle = slacky;
            Specialty = specialty;
            InstructorCohort = cohorty;
        }
    
        public string Specialty { get; set; }
        public Cohort InstructorCohort { get; set; }

        //method to add excersize to Student

         public void AssignExercise(Exercise exercise, Cohort cohort)
        {
            foreach (var student in cohort.StudentsInCohort)
            {
                student.StudentsExercises.Add(exercise);
            }
        }

    }

}