using Microsoft.AspNetCore.Mvc;
using MVCWithEFApp.Repository;

namespace MVCWithEFApp.Controllers
{
    public class OrganisationController : Controller
    {
        private readonly IOrganizationRepostiory _orgnizationRepo;
        public OrganisationController(IOrganizationRepostiory orgRepo) { 
          _orgnizationRepo = orgRepo;
        }
        public IActionResult Index()
        {
             return View(_orgnizationRepo.GetOrganizations());
        }
    }
}
