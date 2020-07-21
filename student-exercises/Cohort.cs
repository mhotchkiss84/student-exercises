using System.Collections.Generic;

namespace student_exercises
{
    public class Cohort
    {
        public string cohortName { get; set; }
        public List<string> students = new List<string>();
        public List<string> instructors = new List<string>();
    }
}