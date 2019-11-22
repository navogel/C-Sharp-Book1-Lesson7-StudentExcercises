

using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {
        public Exercise(List<Exercise> allExercises)
        {
            allExercises.Add(this);
        }
        public string Name { get; set; }
        public string Language { get; set; }
    }

}