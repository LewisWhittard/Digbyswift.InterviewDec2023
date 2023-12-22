using Digbyswift.InterviewDec2023.Infrastructure;

namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<StaffViewModel> ListStaff { get; set; }
        public StaffViewModel FirstStaff { get; set; }

        public HomeIndexViewModel(List<Staff> staff)
        {
            if (staff.Count() != 0)
            {
                List<StaffViewModel> lSVM = new List<StaffViewModel>();

                foreach (Staff item in staff)
                {
                    StaffViewModel sVM = new StaffViewModel(item);
                    lSVM.Add(sVM);
                }

                ListStaff = lSVM;
                FirstStaff = lSVM.FirstOrDefault();
            }
            else
            {
                string[] likes = { "None" };
                Staff noneStaff = new Staff(-1, "None", "None", "None", likes);
                StaffViewModel noneViewModel = new StaffViewModel(noneStaff);
                List<StaffViewModel> lSVM = new List<StaffViewModel>();
                lSVM.Add(noneViewModel);
                ListStaff = lSVM;
                FirstStaff = lSVM.FirstOrDefault();
            }
        }
    }
}
