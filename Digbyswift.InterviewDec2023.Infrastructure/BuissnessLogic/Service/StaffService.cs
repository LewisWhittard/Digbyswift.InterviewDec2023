using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;

namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Service
{
    public class StaffService
    {
        private static StaffRepositoryJson sR { get; set; }

        public StaffService()
        {
            sR = new StaffRepositoryJson();
        }

        public List<Staff> AllStaff()
        {
            return sR.AllStaff().ToList();
        }

        public Staff GetStaffById(int id) 
        {
            return sR.Get(id);
        }
    }
}
