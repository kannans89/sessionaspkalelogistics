using EmployeeMVCApp.Services;
using EmployeeMVCApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) { 
          _employeeService = employeeService;
        
        }
        public IActionResult Index()
        {
            
            var vm = new EmployeeIndexVM();
            vm.IndexTitle = "Index Page for employee";
            vm.IndexHeading = "Employees of KaleLogistics";
            vm.Employees = _employeeService.GetAll().ToList();
            vm.Employeecount = _employeeService.HeadCount();

            return View(vm);
        }

        public IActionResult Add() { 
        
            var vm = new EmployeeAddVM();
            vm.AddTitle = "Adding employee of Kale";
            vm.AddHeading = "Adding employee of Kale";
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddVM vm)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(new Model.Employee
                {
                    Id = vm.Id,
                    Name = vm.Name,
                    IsActive = vm.IsActive,
                });
                return RedirectToAction("Index");
            }
                       
            return View(vm);
        }
    }
}
