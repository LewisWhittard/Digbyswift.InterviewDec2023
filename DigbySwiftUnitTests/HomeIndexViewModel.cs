using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{
    
    public class HomeIndexViewModelUnitTests
    {
        [Fact]
        public void ShouldCreateHomeIndexViewModelWithCorrectData()
        {
            List<Staff> noStaff = new List<Staff>();
            List<Staff> listStaff = new List<Staff>();

            string[] likes1 = new string[] { "Swimming", "Running" };
            Staff staffRow1 = new Staff(0, "Donald Drake", "D.D@digbyswift.com", "Developer", likes1);
            string[] likes2 = new string[] { "Walking", "Camping" };
            Staff staffRow2 = new Staff(1, "Mary Beach", "M.B@digbyswift.com", "Senior Developer", likes2);


            listStaff.Add(staffRow1);
            listStaff.Add(staffRow2 );

            HomeIndexViewModel noStaffViewModel = new HomeIndexViewModel(noStaff);
            HomeIndexViewModel staffViewModel = new HomeIndexViewModel(listStaff);

            Assert.Equal(-1, noStaffViewModel.ListStaffViewModel[0].Id);
            Assert.Equal("None", noStaffViewModel.ListStaffViewModel[0].FullName);
            Assert.Equal("None", noStaffViewModel.ListStaffViewModel[0].Email);
            Assert.Equal("None", noStaffViewModel.ListStaffViewModel[0].JobTitle);
            Assert.Equal("None", noStaffViewModel.ListStaffViewModel[0].Likes);

            Assert.Equal(0, staffViewModel.ListStaffViewModel[0].Id);
            Assert.Equal("Donald Drake", staffViewModel.ListStaffViewModel[0].FullName);
            Assert.Equal("D.D@digbyswift.com", staffViewModel.ListStaffViewModel[0].Email);
            Assert.Equal("Developer", staffViewModel.ListStaffViewModel[0].JobTitle);
            Assert.Equal("Swimming, Running", staffViewModel.ListStaffViewModel[0].Likes);

            Assert.Equal(1, staffViewModel.ListStaffViewModel[1].Id);
            Assert.Equal("Mary Beach", staffViewModel.ListStaffViewModel[1].FullName);
            Assert.Equal("M.B@digbyswift.com", staffViewModel.ListStaffViewModel[1].Email);
            Assert.Equal("Senior Developer", staffViewModel.ListStaffViewModel[1].JobTitle);
            Assert.Equal("Walking, Camping", staffViewModel.ListStaffViewModel[1].Likes);
        }
    }
}
