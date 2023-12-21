using Microsoft.AspNetCore.Mvc;
using Digbyswift.InterviewDec2023.UI.BuissnessLogic.Service;
using Digbyswift.InterviewDec2023.UI.BuissnessLogic.ViewModels;



namespace Digbyswift.InterviewDec2023.UI.Controllers;

public class HomeController : Controller
{
    private StaffService sS { get; set; }

    public HomeController()
    {
        sS = new StaffService();
    }

    public IActionResult Index()
    {
        HomeIndexViewModel hIVM = new HomeIndexViewModel(sS.AllStaff());
        return View(hIVM);
    }

    public IActionResult Edit()
    {
        HomeIndexViewModel hIVM = new HomeIndexViewModel(sS.AllStaff());
        return View(hIVM);
    }


}