using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Model;

namespace DigbySwiftUnitTests
{
    
    public class HomeIndexViewModelUnitTests
    {
        [Fact]
        public void HomeIndexViewModelUnitTest()
        {
            List<Staff> NoStaff = new List<Staff>();
            List<Staff> staff = new List<Staff>();

            string[] likes1 = new string[] { "Swimming", "Running" };
            Staff staffRow1 = new Staff(0, "Donald Drake", "D.D@digbyswift.com", "Developer", likes1);
            string[] likes2 = new string[] { "Walking", "Camping" };
            Staff staffRow2 = new Staff(1, "Mary Beach", "M.B@digbyswift.com", "Senior Developer", likes2);


            staff.Add(staffRow1);
            staff.Add(staffRow2 );

            HomeIndexViewModel NoStaffViewModel = new HomeIndexViewModel(NoStaff);
            HomeIndexViewModel StaffViewModel = new HomeIndexViewModel(staff);

            Assert.Equal(-1, NoStaffViewModel.ListStaffViewModel[0].Id);
            Assert.Equal("None", NoStaffViewModel.ListStaffViewModel[0].FullName);
            Assert.Equal("None", NoStaffViewModel.ListStaffViewModel[0].Email);
            Assert.Equal("None", NoStaffViewModel.ListStaffViewModel[0].JobTitle);
            Assert.Equal("None", NoStaffViewModel.ListStaffViewModel[0].Likes);

            Assert.Equal(0, StaffViewModel.ListStaffViewModel[0].Id);
            Assert.Equal("Donald Drake", StaffViewModel.ListStaffViewModel[0].FullName);
            Assert.Equal("D.D@digbyswift.com", StaffViewModel.ListStaffViewModel[0].Email);
            Assert.Equal("Developer", StaffViewModel.ListStaffViewModel[0].JobTitle);
            Assert.Equal("Swimming, Running", StaffViewModel.ListStaffViewModel[0].Likes);

            Assert.Equal(1, StaffViewModel.ListStaffViewModel[1].Id);
            Assert.Equal("Mary Beach", StaffViewModel.ListStaffViewModel[1].FullName);
            Assert.Equal("M.B@digbyswift.com", StaffViewModel.ListStaffViewModel[1].Email);
            Assert.Equal("Senior Developer", StaffViewModel.ListStaffViewModel[1].JobTitle);
            Assert.Equal("Walking, Camping", StaffViewModel.ListStaffViewModel[1].Likes);
        }
    }
}
