namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;

public interface IStaffRepository
{
    Staff Get(int id);
}

public class StaffRepository : IStaffRepository
{
    public Staff Get(int id)
    {
        return AllStaff().First(x => x.Id == id);
    }

    public IEnumerable<Staff> AllStaff()
    {
        return new Staff[]
        {
            new Staff()
            {
                Id = 123,
                FullName = "Kieron McIntyre",
                Email = "kieron@digbyswift.com",
                JobTitle = "Owner/Lead Developer",
                Likes = new [] {"Code", "Karate"}
            },
            new Staff()
            {
                Id = 556,
                FullName = "Joe Earnshaw",
                Email = "joe@digbyswift.com",
                JobTitle = "Senior Developer"
            },
            new Staff()
            {
                Id = 838,
                FullName = "Owen Manby",
                Email = "owen@digbyswift.com",
                Likes = new [] {"Tintin","Asterix"}
            },
        };
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