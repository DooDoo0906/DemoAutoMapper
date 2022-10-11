using DemoAutoMapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.GetEmployees());
        }
    }
}
