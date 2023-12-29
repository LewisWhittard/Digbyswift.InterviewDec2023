using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Model;



namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<StaffViewModel> ListStaffViewModel { get; set; }


        public HomeIndexViewModel(List<Staff> staff)
        {
            if (staff.Count() != 0)
            {
                List<StaffViewModel> listStaffViewModel = new List<StaffViewModel>();

                foreach (Staff item in staff)
                {
                    StaffViewModel staffViewModel = new StaffViewModel(item);
                    listStaffViewModel.Add(staffViewModel);
                }

                ListStaffViewModel = listStaffViewModel;

            }
            else
            {
                string[] likes = { "None" };
                Staff noneStaff = new Staff(-1, "None", "None", "None", likes);
                StaffViewModel staffViewModel = new StaffViewModel(noneStaff);
                List<StaffViewModel> listStaffViewModel = new List<StaffViewModel>();
                listStaffViewModel.Add(staffViewModel);
                ListStaffViewModel = listStaffViewModel;

            }
        }
    }
}
