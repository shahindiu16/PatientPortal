using Microsoft.AspNetCore.Mvc;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork unitOfWork;

        protected BaseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
