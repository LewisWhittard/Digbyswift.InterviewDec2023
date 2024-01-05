using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{


    public class StaffViewModelUnitTests
    {
        public Staff[] Staff { get; set; }

        public void SetUp()
        {
            Staff = SharedTestData.StaffArray;
        }

        public void Dispose()
        {
            Staff = new Staff[0];
        }

        [Fact]
        public void Ctor_StaffViewModel_PopulatedFromStaffCorrectly()
        {

            SetUp();
            StaffViewModel multipleLikes = new StaffViewModel(Staff[0]);

            Assert.Equal(123, multipleLikes.Id);
            Assert.Equal("Kieron McIntyre", multipleLikes.FullName);
            Assert.Equal("kieron@digbyswift.com", multipleLikes.Email);
            Assert.Equal("Owner/Lead Developer", multipleLikes.JobTitle);
            Assert.Equal("Code, Karate", multipleLikes.Likes);
            Dispose();
        }

        [Fact]
        public void Concatenate_StaffViewModel_ConcatianteOneLike()
        {
            SetUp();
            StaffViewModel sut = new StaffViewModel(Staff[2]);
            Assert.Equal("Tintin", sut.Likes);
            Dispose();
        }

        [Fact]
        public void Concatenate_StaffViewModel_ConcatianteZeroLikes()
        {
            SetUp();
            StaffViewModel sut = new StaffViewModel(Staff[1]);
            Assert.Equal("", sut.Likes);
            Dispose();

        }

        [Fact]
        public void Concatenate_StaffViewModel_MultipleLikes()
        {
            SetUp();
            StaffViewModel sut = new StaffViewModel(Staff[0]);
            Assert.Equal("Code, Karate", sut.Likes);
            Dispose();

        }
    }
}