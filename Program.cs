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

            Excercise excercise1 = new Excercise() {Name = "excercise1", Language = "C#"};
            Excercise excercise2 = new Excercise() {Name = "excercise2", Language = "C#"};
            Excercise excercise3 = new Excercise() {Name = "excercise3", Language = "C#"};
            Excercise excercise4 = new Excercise() {Name = "excercise4", Language = "C#"};

            //use method to add to cohort list and link cohort to student/teacher

                cohort1.AddNewStudent("Steve", "Stevens", "SoS");
                cohort1.AddNewStudent("Beve", "Bevens", "BoB");
                cohort1.AddNewStudent("Fleve", "Flevens", "FoF");
                cohort1.AddNewStudent("Creve", "Crevens", "CoC");
                cohort1.AddNewStudent("Shmeve", "Shmevens", "ShOSh");
                cohort1.AddNewInstructor("Zeve", "Zevens", "ZoZ", "C#");
                cohort1.AddNewInstructor("Heve", "Hevens", "HoH", "C#");
                cohort1.AddNewInstructor("Leve", "Levens", "LoL", "C#");

            //each instructor assigns to methods to a student.

                foreach (var instructor in cohort1.InstructorsInCohort)
                {
                    instructor.AssignExercise(excercise1, cohort1);
                    instructor.AssignExercise(excercise2, cohort1);
                }


                
                



            
        }
    }
}