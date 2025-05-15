namespace Third;

public class UserService
{
    CreateUser create = new();
    HashPassword hash = new();
    LogUserActivity logUser = new();

    public void Handler(string username, string password)
    {
        create.CreateUserMethod(username, password);

        hash.HashPasswordMethod(username);

        logUser.LogUserActivityMethod(username);
    }
}