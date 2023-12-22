using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigbySwiftUnitTests
{
    
    public class HomeIndexViewModelUnitTests
    {
        [Fact]
        public void HomeIndexViewModelUnitTest()
        {
            List<Staff> NoStaff = new List<Staff>();
            List<Staff> staff = new List<Staff>();

            string[] likes1 = new string[] { "Swimming", "Running" };
            Staff staffRow1 = new Staff(0, "Donald Drake", "D.D@digbyswift.com", "Developer", likes1);
            string[] likes2 = new string[] { "Walking", "Camping" };
            Staff staffRow2 = new Staff(1, "Mary Beach", "M.B@digbyswift.com", "Senior Developer", likes2);


            staff.Add(staffRow1);
            staff.Add(staffRow2 );

            HomeIndexViewModel NoStaffViewModel = new HomeIndexViewModel(NoStaff);
            HomeIndexViewModel StaffViewModel = new HomeIndexViewModel(staff);

            Assert.Equal(-1, NoStaffViewModel.ListStaff[0].Id);
            Assert.Equal("None", NoStaffViewModel.ListStaff[0].FullName);
            Assert.Equal("None", NoStaffViewModel.ListStaff[0].Email);
            Assert.Equal("None", NoStaffViewModel.ListStaff[0].JobTitle);
            Assert.Equal("None", NoStaffViewModel.ListStaff[0].Likes);

            Assert.Equal(0, StaffViewModel.ListStaff[0].Id);
            Assert.Equal("Donald Drake", StaffViewModel.ListStaff[0].FullName);
            Assert.Equal("D.D@digbyswift.com", StaffViewModel.ListStaff[0].Email);
            Assert.Equal("Developer", StaffViewModel.ListStaff[0].JobTitle);
            Assert.Equal("Swimming, Running", StaffViewModel.ListStaff[0].Likes);

            Assert.Equal(1, StaffViewModel.ListStaff[1].Id);
            Assert.Equal("Mary Beach", StaffViewModel.ListStaff[1].FullName);
            Assert.Equal("M.B@digbyswift.com", StaffViewModel.ListStaff[1].Email);
            Assert.Equal("Senior Developer", StaffViewModel.ListStaff[1].JobTitle);
            Assert.Equal("Walking, Camping", StaffViewModel.ListStaff[1].Likes);
        }
    }
}
