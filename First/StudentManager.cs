namespace First;

public class StudentManager
{
    RegisterStudent register = new();
    SendWelcomeEmail email = new();
    SaveStudentToDatabase saveStudent = new();

    public void Handler(Student student)
    {
        register.RegisterStudentMethod(student);

        email.SendWelcomeEmailMethod(student.Email);

        saveStudent.SaveStudentToDatabaseMethod(student);
    }
}