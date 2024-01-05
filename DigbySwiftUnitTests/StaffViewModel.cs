using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{


    public class StaffViewModelUnitTests
    {
        [Fact]
        public void Ctor_StaffViewModel_PopulatedFromListOfStaffCorrectly()
        {
            var list = new Staff[]
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
                Likes = new [] {"Tintin"}
            }
        };

            StaffViewModel multipleLikes = new StaffViewModel(list[0]);
            StaffViewModel noLikes = new StaffViewModel(list[1]);
            StaffViewModel oneLike = new StaffViewModel(list[2]);

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
    }
}