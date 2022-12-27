using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Controllers
{
    public class EmployeesControllers : Controller
    {
        private readonly MvcDbContext mvcDbContext;

        public EmployeesControllers(MvcDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await mvcDbContext.Employees.ToListAsync();
            return View(employees);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmpViewModel addEmpRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmpRequest.Name,
                Email = addEmpRequest.Email,
                Salary = addEmpRequest.Salary,
                DateofBirth = addEmpRequest.DateofBirth,
                Department = addEmpRequest.Department
            };

            await mvcDbContext.Employees.AddAsync(employee);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }



    }
}
