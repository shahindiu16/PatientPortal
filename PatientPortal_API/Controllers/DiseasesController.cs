using Microsoft.AspNetCore.Mvc;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseasesController : BaseController
    {
        public DiseasesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var disease = unitOfWork.DiseasesRepository.GetAll().ToList();
            return Ok(disease);
        }
    }
}
