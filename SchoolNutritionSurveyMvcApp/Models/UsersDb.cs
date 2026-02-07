using System.Text.Json;

public class UsersDb
{
    private readonly string filePath = "UsersDb.json";
    public void AddToDatabase(UserFormModel user)
    {
        List<UserFormModel> users;

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<UserFormModel>>(json) ?? new List<UserFormModel>();
        }
        else
        {
            users = new List<UserFormModel>();
        }

        users.Add(user);
        File.WriteAllText(filePath, JsonSerializer.Serialize(users));
    }

    public List<UserFormModel> GetUsers()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            var users = JsonSerializer.Deserialize<List<UserFormModel>>(json) ?? new List<UserFormModel>();
            return users;
        }
        return null;
    }
}