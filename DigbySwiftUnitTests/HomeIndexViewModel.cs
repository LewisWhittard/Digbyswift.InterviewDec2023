using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{
    public class HomeIndexViewModelUnitTests
    {
        public List<Staff> listStaff {  get; set; }

        public void SetUp()
        {
            listStaff = SharedTestData.StaffArray.ToList();
        }

        [Fact]
        public void Ctor_HomeIndexViewModel_Populated()
        {
            SetUp();
            HomeIndexViewModel sut = new HomeIndexViewModel(listStaff);
            Assert.Equal(123, sut.ListStaffViewModel[0].Id);
            Assert.Equal("Kieron McIntyre", sut.ListStaffViewModel[0].FullName);
            Assert.Equal("kieron@digbyswift.com", sut.ListStaffViewModel[0].Email);
            Assert.Equal("Owner/Lead Developer", sut.ListStaffViewModel[0].JobTitle);
            Assert.Equal("Code, Karate", sut.ListStaffViewModel[0].Likes);
            Dispose();
        }

        public void Dispose()
        {
            listStaff.Clear();
        }

        [Fact]
        public void Ctor_HomeIndexViewModel_Unpopulated()
        {
            SetUp();
            Dispose();
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
