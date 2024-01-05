using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Repository;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Service;

namespace DigbySwiftUnitTests
{
    public class StaffServiceUnitTests
    {
        [Fact]
        public void GetAllStaff_AllStaffAsList_Correctly()
        {
            StaffRepositoryJson staffRepository = new StaffRepositoryJson();
            StaffService staffService = new StaffService(staffRepository);

            var listStaff = staffService.GetAllStaff();

            Assert.Equal(123, listStaff[0].Id);
            Assert.Equal("Kieron McIntyre", listStaff[0].FullName);
            Assert.Equal("kieron@digbyswift.com", listStaff[0].Email);
            Assert.Equal("Owner/Lead Developer", listStaff[0].JobTitle);
            Assert.Equal("Code", listStaff[0].Likes[0]);
            Assert.Equal("Karate", listStaff[0].Likes[1]);

            Assert.Equal(556, listStaff[1].Id);
            Assert.Equal("Joe Earnshaw", listStaff[1].FullName);
            Assert.Equal("joe@digbyswift.com", listStaff[1].Email);
            Assert.Equal("Senior Developer", listStaff[1].JobTitle);
            Assert.Equal(null, listStaff[1].Likes);

            Assert.Equal(838, listStaff[2].Id);
            Assert.Equal("Owen Manby", listStaff[2].FullName);
            Assert.Equal("owen@digbyswift.com", listStaff[2].Email);
            Assert.Equal(null, listStaff[2].JobTitle);
            Assert.Equal("Tintin", listStaff[2].Likes[0]);
            Assert.Equal("Asterix", listStaff[2].Likes[1]);
        }

        [Fact]
        public void Get_IndividualStaff_Correctly()
        {
            StaffRepositoryJson staffRepository = new StaffRepositoryJson();
            StaffService staffService = new StaffService(staffRepository);

            var listStaff0 = staffService.GetStaffById(123);
            var listStaff1 = staffService.GetStaffById(838);

            Assert.Equal(123, listStaff0.Id);
            Assert.Equal("Kieron McIntyre", listStaff0.FullName);
            Assert.Equal("kieron@digbyswift.com", listStaff0.Email);
            Assert.Equal("Owner/Lead Developer", listStaff0.JobTitle);
            Assert.Equal("Code", listStaff0.Likes[0]);
            Assert.Equal("Karate", listStaff0.Likes[1]);

            Assert.Equal(838, listStaff1.Id);
            Assert.Equal("Owen Manby", listStaff1.FullName);
            Assert.Equal("owen@digbyswift.com", listStaff1.Email);
            Assert.Equal(null, listStaff1.JobTitle);
            Assert.Equal("Tintin", listStaff1.Likes[0]);
            Assert.Equal("Asterix", listStaff1.Likes[1]);
        }


    }
}
