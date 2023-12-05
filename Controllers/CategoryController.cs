using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVCapp.Models;

namespace MyMVCapp.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index(){
        return View();
    }
}
