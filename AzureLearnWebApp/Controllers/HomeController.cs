using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AzureLearnWebApp.Models;
using AzureLearnWebApp.Services.Interfaces;
namespace AzureLearnWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    private readonly IService<Course> _courseService;
    public HomeController(ILogger<HomeController> logger, IService<Course> courseService)
    {
        _logger = logger;
        _courseService = courseService;
    }

    public IActionResult Index()
    {
        List<Course> courses = _courseService.GetAll();
        if(courses != null)
        {
            return View(courses);
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
