using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleProjectApi.Models;

namespace SimpleProjectApi.Controllers;

public class HomeController : Controller
{

    [HttpGet("/Home")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/Error")]
    public IActionResult Error()
    {
        return View();
    }

}
