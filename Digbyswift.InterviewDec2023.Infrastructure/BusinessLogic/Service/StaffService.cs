using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Repository;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Model;


namespace Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Service
{
    public class StaffService
    {
        private static StaffRepositoryJson _staffRepository { get; set; }

        public StaffService(StaffRepositoryJson staffRepository)
        {
            
            _staffRepository = staffRepository;
        }

        public List<Staff> GetAllStaff()
        {
            return _staffRepository.GetAllStaff().ToList();
        }

        public Staff GetStaffById(int id) 
        {
            return _staffRepository.Get(id);
        }
    }
}
