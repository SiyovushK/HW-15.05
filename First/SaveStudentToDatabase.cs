namespace First;

public class SaveStudentToDatabase
{
    public void SaveStudentToDatabaseMethod(Student student)
    { 
        System.Console.WriteLine($"Student {student.Name} has been saved to database");
    }
}