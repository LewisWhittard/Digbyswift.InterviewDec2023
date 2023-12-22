using Digbyswift.InterviewDec2023.Infrastructure;

namespace DigbySwiftUnitTests
{
    public class StaffRepositoryUnitTests
    {
        [Fact]
        public void AllStaff()
        {
            StaffRepository sR = new StaffRepository();

            var Data = sR.AllStaff().ToList();

            Assert.Equal(123, Data[0].Id);
            Assert.Equal("Kieron McIntyre", Data[0].FullName);
            Assert.Equal("kieron@digbyswift.com", Data[0].Email);
            Assert.Equal("Owner/Lead Developer", Data[0].JobTitle);
            Assert.Equal("Code", Data[0].Likes[0]);
            Assert.Equal("Karate", Data[0].Likes[1]);

            Assert.Equal(556, Data[1].Id);
            Assert.Equal("Joe Earnshaw", Data[1].FullName);
            Assert.Equal("joe@digbyswift.com", Data[1].Email);
            Assert.Equal("Senior Developer", Data[1].JobTitle);
            Assert.Equal (null , Data[1].Likes);

            Assert.Equal(838, Data[2].Id);
            Assert.Equal("Owen Manby", Data[2].FullName);
            Assert.Equal("owen@digbyswift.com", Data[2].Email);
            Assert.Equal(null, Data[2].JobTitle);
            Assert.Equal("Tintin", Data[2].Likes[0]);
            Assert.Equal("Asterix", Data[2].Likes[1]);

        }

        [Fact]
        public void GetById()
        {
            StaffRepository sR = new StaffRepository();

            var Data0 = sR.Get(123);
            var Data1 = sR.Get(838);

            Assert.Equal(123, Data0.Id);
            Assert.Equal("Kieron McIntyre", Data0.FullName);
            Assert.Equal("kieron@digbyswift.com", Data0.Email);
            Assert.Equal("Owner/Lead Developer", Data0.JobTitle);
            Assert.Equal("Code", Data0.Likes[0]);
            Assert.Equal("Karate", Data0.Likes[1]);

            Assert.Equal(838, Data1.Id);
            Assert.Equal("Owen Manby", Data1.FullName);
            Assert.Equal("owen@digbyswift.com", Data1.Email);
            Assert.Equal(null, Data1.JobTitle);
            Assert.Equal("Tintin", Data1.Likes[0]);
            Assert.Equal("Asterix", Data1.Likes[1]);
        }
    }
}