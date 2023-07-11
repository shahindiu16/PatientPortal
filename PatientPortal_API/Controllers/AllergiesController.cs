using Microsoft.AspNetCore.Mvc;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergiesController : BaseController
    {
        public AllergiesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        [HttpGet]
        public IActionResult Get()
        {
            var disease = unitOfWork.AllergiesRepository.GetAll().ToList();
            return Ok(disease);
        }
    }
}
