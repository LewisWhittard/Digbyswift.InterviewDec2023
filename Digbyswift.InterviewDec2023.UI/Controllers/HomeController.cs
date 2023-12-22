using Microsoft.AspNetCore.Mvc;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Service;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels;



namespace Digbyswift.InterviewDec2023.Infrastructure.Controllers;

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

    [HttpGet("/employee/{id}")]
    public IActionResult GetStaff(int iD)
    {
        var Data = sS.GetStaffById(iD);
        StaffViewModel sVM = new StaffViewModel(Data);
        return Json(sVM);
    }


}