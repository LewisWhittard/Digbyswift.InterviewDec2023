using Digbyswift.InterviewDec2023.Infrastructure;

namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Service
{
    public class StaffService
    {
        private StaffRepository sR { get; set; }

        public StaffService()
        {
            sR = new StaffRepository();
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
