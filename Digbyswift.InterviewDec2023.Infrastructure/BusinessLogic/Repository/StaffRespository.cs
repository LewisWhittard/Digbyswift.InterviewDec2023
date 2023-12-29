using Newtonsoft.Json;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Model;


namespace Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Repository;


public interface IStaffRepository
{
    Staff Get(int id);
    IEnumerable<Staff> GetAllStaff();
}

public class StaffRepositoryJson : IStaffRepository
{
    public Staff Get(int id)
    {
        return GetAllStaff().First(x => x.Id == id);
    }

    public IEnumerable<Staff> GetAllStaff()
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

        StaffContainer staffContainer = JsonConvert.DeserializeObject<StaffContainer>(jsonContent, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        return staffContainer.Staff;
    }
}



