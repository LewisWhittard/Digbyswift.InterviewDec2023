using Digbyswift.InterviewDec2023.Infrastructure;

namespace Digbyswift.InterviewDec2023.UI.BuissnessLogic.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Staff> ListStaff { get; set; }

        public HomeIndexViewModel(List<Staff> staff)
        {
            ListStaff = staff;
        }
    }
}
