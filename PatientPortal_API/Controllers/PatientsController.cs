using Microsoft.AspNetCore.Mvc;
using PatientPortal_API.Models;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : BaseController
    {
        public PatientsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var patients = unitOfWork.PatientRepository.GetAll().ToList();
            return Ok(patients);
        }
        [HttpPost]
        public IActionResult Post([FromBody] PatientViewModel vm)
        {
            unitOfWork.PatientRepository.AddWithDependency(vm);
            unitOfWork.SaveChanges();
            return Ok(vm);
        }
    }
}
