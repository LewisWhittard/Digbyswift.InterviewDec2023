using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigbySwiftUnitTests
{
    public class StaffViewModelUnitTests
    {
        [Fact]
        public void ContructViewModel()
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

            StaffViewModel MultipleLikes = new StaffViewModel(list[0]);
            StaffViewModel NoLikes = new StaffViewModel(list[1]);
            StaffViewModel OneLike = new StaffViewModel(list[2]);

            Assert.Equal(123, MultipleLikes.Id);
            Assert.Equal("Kieron McIntyre", MultipleLikes.FullName);
            Assert.Equal("kieron@digbyswift.com", MultipleLikes.Email);
            Assert.Equal("Owner/Lead Developer", MultipleLikes.JobTitle);
            Assert.Equal("Code, Karate", MultipleLikes.Likes);

            Assert.Equal(556, NoLikes.Id);
            Assert.Equal("Joe Earnshaw", NoLikes.FullName);
            Assert.Equal("joe@digbyswift.com",NoLikes.Email);
            Assert.Equal("Senior Developer", NoLikes.JobTitle);
            Assert.Equal("None", NoLikes.Likes);

            Assert.Equal(838, OneLike.Id);
            Assert.Equal("Owen Manby", OneLike.FullName);
            Assert.Equal("owen@digbyswift.com", OneLike.Email);
            Assert.Equal(null, OneLike.JobTitle);
            Assert.Equal("Tintin", OneLike.Likes);

        }
    }
}