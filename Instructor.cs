

using System;

namespace C_StudentExercises2
{
    public class Instructor
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string SlackHandle {get;set;}
        public Cohort CohortName {get;set;}
        public void AssignStudents(Cohort cohort, Exercise exercise) {
            foreach(Student student in cohort.StudentList) {
            student.ExerciseList.Add(exercise);
            // Console.WriteLine($"{FirstName} assigned {exercise.ExerciseName} to {student.FirstName} who is in {cohort.CohortName}");
            }
        }

        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohortName) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortName = cohortName;
        }

    }
}
