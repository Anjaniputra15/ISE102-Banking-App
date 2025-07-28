namespace BankingApp;

public class Bank
{
    private List<User> users = new List<User>();

    public Bank()
    {
        // Add a default user for testing
        users.Add(new User
        {
            Username = "Joe.Doe",
            Password = "Password123",
            Email = "joe.doe@example.com",
            Age = 30,
            Phone = "123-456-7890"
        });
    }

    public bool SignUp(string username, string email, int age, string phone, string password)
    {
        if (users.Any(u => u.Username == username))
        {
            return false; // User already exists
        }
        
        users.Add(new User
        {
            Username = username,
            Email = email,
            Age = age,
            Phone = phone,
            Password = password
        });
        return true; // Signup successful
    }

    public bool Login(string username, string password)
    {
        return users.Any(u => u.Username == username && u.Password == password);
    }
} 