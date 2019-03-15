using System.Collections.Generic;

namespace C_StudentExercises2
{
    public class Student
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string SlackHandle {get;set;}
        public Cohort CohortName {get;set;}
        public List<Exercise> ExerciseList {get;set;}

        public Student(string firstName, string lastName, string slackHandle, Cohort cohort) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            ExerciseList = new List<Exercise>();
            CohortName = cohort;
        }
    }
}
