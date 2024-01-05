using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{
    
    public class HomeIndexViewModelUnitTests
    {
        [Fact]
        public void Ctor_HomeIndexViewModel_Populated()
        {
            List<Staff> listStaff = new List<Staff>();

            string[] likes1 = new string[] { "Swimming", "Running" };
            Staff staffRow1 = new Staff(0, "Donald Drake", "D.D@digbyswift.com", "Developer", likes1);
            string[] likes2 = new string[] { "Walking", "Camping" };
            Staff staffRow2 = new Staff(1, "Mary Beach", "M.B@digbyswift.com", "Senior Developer", likes2);


            listStaff.Add(staffRow1);
            listStaff.Add(staffRow2 );

            HomeIndexViewModel sut = new HomeIndexViewModel(listStaff);

            Assert.Equal(0, sut.ListStaffViewModel[0].Id);
            Assert.Equal("Donald Drake", sut.ListStaffViewModel[0].FullName);
            Assert.Equal("D.D@digbyswift.com", sut.ListStaffViewModel[0].Email);
            Assert.Equal("Developer", sut.ListStaffViewModel[0].JobTitle);
            Assert.Equal("Swimming, Running", sut.ListStaffViewModel[0].Likes);

            Assert.Equal(1, sut.ListStaffViewModel[1].Id);
            Assert.Equal("Mary Beach", sut.ListStaffViewModel[1].FullName);
            Assert.Equal("M.B@digbyswift.com", sut.ListStaffViewModel[1].Email);
            Assert.Equal("Senior Developer", sut.ListStaffViewModel[1].JobTitle);
            Assert.Equal("Walking, Camping", sut.ListStaffViewModel[1].Likes);
        }

        [Fact]
        public void Ctor_HomeIndexViewModel_Unpopulated()
        {
            List<Staff> Staff = new List<Staff>();

            HomeIndexViewModel sut = new HomeIndexViewModel(Staff);

            Assert.Equal(-1, sut.ListStaffViewModel[0].Id);
            Assert.Equal("None", sut.ListStaffViewModel[0].FullName);
            Assert.Equal("None", sut.ListStaffViewModel[0].Email);
            Assert.Equal("None", sut.ListStaffViewModel[0].JobTitle);
            Assert.Equal("None", sut.ListStaffViewModel[0].Likes);
        }
    }
}
