using Microsoft.AspNetCore.Mvc;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Service;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;



namespace Digbyswift.InterviewDec2023.Infrastructure.Controllers;

public class HomeController : Controller
{
    private static StaffService _staffService { get; set; }

    public HomeController()
    {
        _staffService = new StaffService();
    }

    public IActionResult Index()
    {
        HomeIndexViewModel viewModel = new HomeIndexViewModel(_staffService.GetAllStaff());
        return View(viewModel);
    }

    [HttpGet("/employee/{id}")]
    public IActionResult GetStaff(int id)
    {
        var data = _staffService.GetStaffById(id);
        StaffViewModel viewModel = new StaffViewModel(data);
        return Json(viewModel);
    }
}