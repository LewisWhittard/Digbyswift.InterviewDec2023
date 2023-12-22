using Newtonsoft.Json;
using System.Text.Json;

namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;


public interface IStaffRepository
{
    Staff Get(int id);
}

public class StaffRepositoryJson : IStaffRepository
{
    public Staff Get(int id)
    {
        return AllStaff().First(x => x.Id == id);
    }

    public IEnumerable<Staff> AllStaff()
    {
        // Specify the path to your JSON file
        string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory() + "/Data", "Staff.json");

        // Read the entire JSON file content
        string jsonContent = File.ReadAllText(jsonFilePath);

        // Check if the JSON content is empty
        if (string.IsNullOrWhiteSpace(jsonContent))
        {
            return new List<Staff>();
        }

        StaffContainer sC = JsonConvert.DeserializeObject<StaffContainer>(jsonContent, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        return sC.Staff;
    }
}



public class Staff
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string JobTitle { get; set; }
    public string[] Likes { get; set; }

    public Staff()
    {

    }

    public Staff(int iD, string fullName, string email, string jobTitle, string[] likes)
    {
        Id = iD;
        FullName = fullName;
        Email = email;
        JobTitle = jobTitle;
        Likes = likes;
    }
}

public class StaffContainer
{
    public Staff[] Staff { get; set; }

    public StaffContainer()
    {
        
    }

    public StaffContainer(Staff[] data)
    {
        Staff = data;
    }

}