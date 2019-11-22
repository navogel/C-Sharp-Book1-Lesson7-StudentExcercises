﻿using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> allStudents = new List<Student>();
            List<Exercise> allExercises = new List<Exercise>();

            Cohort cohort1 = new Cohort("Cohort 1");
            Cohort cohort2 = new Cohort("Cohort 2");
            Cohort cohort3 = new Cohort("Cohort 3");

            Exercise excercise1 = new Exercise(allExercises) {Name = "excercise1", Language = "C#"};
            Exercise excercise2 = new Exercise(allExercises) {Name = "excercise2", Language = "C#"};
            Exercise excercise3 = new Exercise(allExercises) {Name = "excercise3", Language = "C#"};
            Exercise excercise4 = new Exercise(allExercises) {Name = "excercise4", Language = "C#"};
            Exercise excercise5 = new Exercise(allExercises) {Name = "excercise5", Language = "C#"};
            Exercise excercise6 = new Exercise(allExercises) {Name = "excercise6", Language = "C#"};

            //use method to add to cohort list and link cohort to student/teacher

                cohort1.AddNewStudent("Steve", "Stevens", "SoS", allStudents);
                cohort1.AddNewStudent("Beve", "Bevens", "BoB", allStudents);
                cohort2.AddNewStudent("Fleve", "Flevens", "FoF", allStudents);
                cohort2.AddNewStudent("Creve", "Crevens", "CoC", allStudents);
                cohort3.AddNewStudent("Shmeve", "Shmevens", "ShOSh", allStudents);
                cohort3.AddNewStudent("Dreve", "Drevens", "DoD", allStudents);
                // cohort1.AddNewInstructor("Zeve", "Zevens", "ZoZ", "C#");
                // cohort1.AddNewInstructor("Heve", "Hevens", "HoH", "C#");
                // cohort1.AddNewInstructor("Leve", "Levens", "LoL", "C#");

                Instructor instructor1 = new Instructor("Zeve", "Zevens", "ZoZ", "C#", cohort1);
                cohort1.InstructorsInCohort.Add(instructor1);
                Instructor instructor2 = new Instructor("Heve", "Hevens", "HoH", "C#", cohort2);
                cohort2.InstructorsInCohort.Add(instructor2);
                Instructor instructor3 = new Instructor("Leve", "Levens", "LoL", "C#", cohort3);
                cohort3.InstructorsInCohort.Add(instructor3);

            //each instructor assigns to methods to a student.

                    instructor1.AssignExercise(excercise1, cohort1);
                    instructor1.AssignExercise(excercise2, cohort1);
                    instructor2.AssignExercise(excercise1, cohort2);
                    instructor2.AssignExercise(excercise2, cohort2);
                    instructor3.AssignExercise(excercise1, cohort3);
                    instructor3.AssignExercise(excercise2, cohort3);
                

                

            

        }

                
                



            
        }
    }
