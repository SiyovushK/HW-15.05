using First;

StudentManager studentManager = new();

Student student = new()
{
    Name = "Siyovush",
    Email = "MeEmail@gmail.com"
};

studentManager.Handler(student);