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

        [Fact]
        public void Ctor_StaffViewModel_PopulatedFromStaffCorrectly()
        {


            StaffViewModel multipleLikes = new StaffViewModel(Staff[0]);
            StaffViewModel noLikes = new StaffViewModel(Staff[1]);
            StaffViewModel oneLike = new StaffViewModel(Staff[2]);

            Assert.Equal(123, multipleLikes.Id);
            Assert.Equal("Kieron McIntyre", multipleLikes.FullName);
            Assert.Equal("kieron@digbyswift.com", multipleLikes.Email);
            Assert.Equal("Owner/Lead Developer", multipleLikes.JobTitle);
            Assert.Equal("Code, Karate", multipleLikes.Likes);

            Assert.Equal(556, noLikes.Id);
            Assert.Equal("Joe Earnshaw", noLikes.FullName);
            Assert.Equal("joe@digbyswift.com",noLikes.Email);
            Assert.Equal("Senior Developer", noLikes.JobTitle);
            Assert.Equal("", noLikes.Likes);

            Assert.Equal(838, oneLike.Id);
            Assert.Equal("Owen Manby", oneLike.FullName);
            Assert.Equal("owen@digbyswift.com", oneLike.Email);
            Assert.Equal(null, oneLike.JobTitle);
            Assert.Equal("Tintin", oneLike.Likes);

        }

        [Fact]
        public void Concatenate_StaffViewModel_ConcatianteOneLike()
        {
            StaffViewModel sut = new StaffViewModel(Staff[2]);
            
            Assert.Equal("Tintin", sut.Likes);

        }

        [Fact]
        public void Concatenate_StaffViewModel_ConcatianteZeroLikes()
        {
            StaffViewModel sut = new StaffViewModel(Staff[1]);

            Assert.Equal("", sut.Likes);

        }

        [Fact]
        public void Concatenate_StaffViewModel_MultipleLikes()
        {

            StaffViewModel sut = new StaffViewModel(Staff[0]);

            Assert.Equal("Code, Karate", sut.Likes);

        }
    }
}