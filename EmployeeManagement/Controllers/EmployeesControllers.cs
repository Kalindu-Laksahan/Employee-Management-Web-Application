using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeesControllers : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



    }
}
