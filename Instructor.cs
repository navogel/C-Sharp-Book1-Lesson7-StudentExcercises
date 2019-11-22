using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public Instructor(string firsty, string lasty, string slacky, string specialty, Cohort cohorty )
        {
            FirstName = firsty;
            LastName = lasty;
            SlackHandle = slacky;
            Specialty = specialty;
            InstructorCohort = cohorty;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Specialty { get; set; }
        public Cohort InstructorCohort { get; set; }

        //method to add excersize to Student

        public void AddExcercise(Student sName, Excercise xName)
        {
            sName.StudentsExcercises.Add(xName);
        }

    }

}