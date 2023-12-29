using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Repository;

namespace DigbySwiftUnitTests
{
    public class StaffRepositoryUnitTests
    {
        [Fact]
        public void GetAllStaff()
        {
            StaffRepositoryJson staffRepository = new StaffRepositoryJson();

            var data = staffRepository.GetAllStaff().ToList();

            Assert.Equal(123, data[0].Id);
            Assert.Equal("Kieron McIntyre", data[0].FullName);
            Assert.Equal("kieron@digbyswift.com", data[0].Email);
            Assert.Equal("Owner/Lead Developer", data[0].JobTitle);
            Assert.Equal("Code", data[0].Likes[0]);
            Assert.Equal("Karate", data[0].Likes[1]);

            Assert.Equal(556, data[1].Id);
            Assert.Equal("Joe Earnshaw", data[1].FullName);
            Assert.Equal("joe@digbyswift.com", data[1].Email);
            Assert.Equal("Senior Developer", data[1].JobTitle);
            Assert.Equal (null , data[1].Likes);

            Assert.Equal(838, data[2].Id);
            Assert.Equal("Owen Manby", data[2].FullName);
            Assert.Equal("owen@digbyswift.com", data[2].Email);
            Assert.Equal(null, data[2].JobTitle);
            Assert.Equal("Tintin", data[2].Likes[0]);
            Assert.Equal("Asterix", data[2].Likes[1]);

        }

        [Fact]
        public void GetById()
        {
            StaffRepositoryJson staffRepository = new StaffRepositoryJson();

            var data0 = staffRepository.Get(123);
            var data1 = staffRepository.Get(838);

            Assert.Equal(123, data0.Id);
            Assert.Equal("Kieron McIntyre", data0.FullName);
            Assert.Equal("kieron@digbyswift.com", data0.Email);
            Assert.Equal("Owner/Lead Developer", data0.JobTitle);
            Assert.Equal("Code", data0.Likes[0]);
            Assert.Equal("Karate", data0.Likes[1]);

            Assert.Equal(838, data1.Id);
            Assert.Equal("Owen Manby", data1.FullName);
            Assert.Equal("owen@digbyswift.com", data1.Email);
            Assert.Equal(null, data1.JobTitle);
            Assert.Equal("Tintin", data1.Likes[0]);
            Assert.Equal("Asterix", data1.Likes[1]);
        }
    }
}