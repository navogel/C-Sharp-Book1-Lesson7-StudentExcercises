using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort1 = new Cohort("Cohort 1");
            Cohort cohort2 = new Cohort("Cohort 2");
            Cohort cohort3 = new Cohort("Cohort 3");

            //use method to add to cohort list and link cohort to student/teacher

                cohort1.AddNewStudent("Steve", "Stevens", "SOS");

            //create variable with new student/teacher, then manually add to list

                Student Student1 = new Student("Traci", "Shannon", "TS", cohort1);
                cohort1.StudentsInCohort.Add(Student1);

                //testing changing the cohort association.  how to link it to list?
                Student1.StudentCohort = cohort2;
                //linked cohort changes, list stays the same
                Console.WriteLine(Student1.StudentCohort.Name);

            //add to list and create variable at the same time

                cohort1.InstructorsInCohort.Add(
                    new Instructor("Hooper", "Blooper", "HUB", "C#", cohort1)
                );
        }
    }
}