using Microsoft.AspNetCore.Mvc;
using MVCWithEFApp.Domain;
using MVCWithEFApp.Repository;

namespace MVCWithEFApp.Controllers
{
    public class OrganisationController : Controller
    {
        private readonly IOrganizationRepostiory _orgnizationRepo;
        public OrganisationController(IOrganizationRepostiory orgRepo)
        {
            _orgnizationRepo = orgRepo;
        }
        public IActionResult Index()
        {
            return View(_orgnizationRepo.GetOrganizations());
        }

        public IActionResult Add()
        {
            Organization vm = new Organization();
            vm.Id = 0;
            vm.Name = string.Empty;

            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(Organization vm)
        {

            _orgnizationRepo.AddOrganization(vm);

            return  RedirectToAction("Index");
        }

        public IActionResult Edit(int id) {

          var vm=  _orgnizationRepo.GetOrganizationById(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(Organization vm)
        {
            _orgnizationRepo.UpdateOrganization(vm);

            return RedirectToAction("Index");
          
        }
    }
}
