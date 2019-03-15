using System;
using System.Collections.Generic;
using System.Linq;

namespace C_StudentExercises2
{
    class CohortRoster {
    public Cohort CohortName {get; set;}
    public int StudentCount {get; set;}
}
    class Program
    {
        static void Main(string[] args)
        {
            // After your code where you created all of your instances, add each one to the lists.
            Cohort Cohort31 = new Cohort();
            Cohort Cohort30 = new Cohort();
            Cohort Cohort29 = new Cohort();
            List<Cohort> cohorts = new List<Cohort>(){
                Cohort31,
                Cohort30,
                Cohort29
            };
            Student Larry = new Student("Larry","Bob","@larryknowsitall", Cohort31);
            Student Kristin = new Student("Kristin", "Stewart", "@vamplover25", Cohort30);
            Student Loshanna = new Student("Loshanna", "Jaffery","@shoshj", Cohort29);
            Student Tre = new Student("Tre", "Smith", "@trebby", Cohort29);
            List<Student> students = new List<Student>() {
                Larry,
                Kristin,
                Loshanna,
                Tre
            };
            Exercise OverlyExcited = new Exercise("OverlyExcited", "JavaScript");
            Exercise SolarSystem = new Exercise("SolarSystem", "C#");
            Exercise CarLot = new Exercise("CarLot", "JavaScript");
            Exercise DynamicCards = new Exercise("DynamicCards", "JavaScript");
            List<Exercise> exercises = new List<Exercise>() {
                OverlyExcited,
                SolarSystem,
                CarLot,
                DynamicCards
            };
            Instructor Jisie = new Instructor("Jisie", "David", "@therealjisie", Cohort31);
            Instructor Andy = new Instructor("Andy", "Collins", "@askingalot", Cohort29);
            Instructor Steve = new Instructor("Steve", "Brownlee", "@steviesteve", Cohort30);
            List<Instructor> instructors = new List<Instructor>(){
                Jisie,
                Andy,
                Steve
            };

// List exercises for the JavaScript language by using the Where() LINQ method.
            List<Exercise> JSExercises = (from exercise in exercises
            where exercise.ExerciseLang == "JavaScript"
            select exercise).ToList();

// List students in a particular cohort by using the Where() LINQ method.
            List<Student> Cohort29Students = (from student in students
            where student.CohortName == Cohort29
            select student
            ).ToList();


// List instructors in a particular cohort by using the Where() LINQ method.
        List<Instructor> Cohort30Instructor = (from instructor in instructors
        where instructor.CohortName == Cohort29
        select instructor).ToList();

// Sort the students by their last name.
    List<Student> StudentsByLastName = (from student in students
        orderby student.LastName
        select student).ToList();

// Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
    Larry.ExerciseList.Add(OverlyExcited);
    Kristin.ExerciseList.Add(SolarSystem);
    Loshanna.ExerciseList.Add(DynamicCards);
    Loshanna.ExerciseList.Add(CarLot);

    List<Student> StudentWithoutExercises = (from student in students
        where student.ExerciseList.Count() == 0
        select student).ToList();

// Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
    List<Student> StudentWithMostExercises = (from student in students
    orderby student.ExerciseList.Count descending
    select student).ToList();

// How many students in each cohort?
    List<CohortRoster> StudentsInCohort = (from student in students
    group student.FirstName by student.CohortName into cohortRoster
    select new CohortRoster {
        CohortName = cohortRoster.Key,
        StudentCount = cohortRoster.Count()
        }).ToList();
        }
    };
}
