

using System.Collections.Generic;

namespace C_StudentExercises2
{
    public class Cohort
    {
       public string CohortName {get;set;}
       public List<Student> StudentList {get;set;}
       public List<Instructor> InstructorList{get;set;}

       public Cohort() {
        StudentList = new List<Student>();
        InstructorList = new List<Instructor>();
       }

    }
}
