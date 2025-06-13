using AzureLearnWebApp.Models;
using AzureLearnWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AzureLearnWebApp.Controllers
{
    public class AuthorController : Controller
    {
        IService<Author> _authorService;
        public AuthorController(IService<Author> authorService)
        {
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            List<Author> authors = _authorService.GetAll();
            if (authors != null)
            {
                return View(authors);
            }
            return View();
        }
    }
}
