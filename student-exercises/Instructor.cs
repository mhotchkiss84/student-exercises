namespace student_exercises
{
    public class Instructor : Person
    {
        public string specialty { get; set; }
    /*Making a method to assign students to an exercise*/
    public void assignExercise(Student student, Exercise exercise)
    {
        student.currentExercises.Add(exercise);
    }
    }
}