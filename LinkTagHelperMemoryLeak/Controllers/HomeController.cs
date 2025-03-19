using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace LinkTagHelperMemoryLeak.Controllers;

public class HomeController : Controller
{
    private readonly MemoryHogService _memoryHogService;

    public HomeController(MemoryHogService memoryHogService)
    {
        _memoryHogService = memoryHogService;
    }

    [Route("~/")]
    public IActionResult Index()
    {
        return View();
    }

}
