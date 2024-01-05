using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;

namespace DigbySwiftUnitTests
{
    public static class SharedTestData
    {
        public static Staff[] StaffArray = new Staff[]
            {
                new Staff()
        {
            Id = 123,
                    FullName = "Kieron McIntyre",
                    Email = "kieron@digbyswift.com",
                    JobTitle = "Owner/Lead Developer",
                    Likes = new[] { "Code", "Karate" }
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
                Likes = new[] { "Tintin" }
            }
    };


        }
}
