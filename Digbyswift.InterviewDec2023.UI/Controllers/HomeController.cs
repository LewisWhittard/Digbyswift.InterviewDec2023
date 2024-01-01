using Microsoft.AspNetCore.Mvc;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Service;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels;
using Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.Repository;



namespace Digbyswift.InterviewDec2023.Infrastructure.Controllers;

public class HomeController : Controller
{
    private static StaffService _staffService { get; set; }

    public HomeController()
    {
        StaffRepositoryJson staffRepositoryJson = new StaffRepositoryJson();
        _staffService = new StaffService(staffRepositoryJson);
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