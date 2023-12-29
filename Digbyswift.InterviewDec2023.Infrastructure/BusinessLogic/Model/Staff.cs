namespace Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model
{
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
}
