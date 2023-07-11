using Microsoft.AspNetCore.Mvc;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NcdController : BaseController
    {
        public NcdController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        [HttpGet]
        public IActionResult Get()
        {
            var ncd = unitOfWork.NcdRepository.GetAll().ToList();
            return Ok(ncd);
        }
    }
}
