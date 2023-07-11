using Microsoft.AspNetCore.Mvc;
using PatientPortal_WebApp.Models;
using PatientPortal_WebApp.Models.Enums;
using PatientPortal_WebApp.Utilities;
namespace PatientPortal_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
            _baseUrl = AppSettings.BaseUrl;
        }

        public async Task<IActionResult> Index()
        {
            var epilepsy = Enum.GetValues(typeof(Epilepsy))
                         .Cast<Epilepsy>()
                         .Select(e => new DropDown
                         {
                             Name = e.ToString(),
                             Id = (int)e
                         }).ToList();

            ViewBag.Epilepsy = epilepsy;

            var diseases = BaseApiService.GetAsync<List<DropDown>>(_httpClient, "Diseases");
            var ncd = BaseApiService.GetAsync<List<DropDown>>(_httpClient, "Ncd");
            var allergies = BaseApiService.GetAsync<List<DropDown>>(_httpClient, "Allergies");


            var taskResult = await Task.WhenAll(diseases, ncd, allergies);
            ViewBag.Disease = diseases.Result;
            ViewBag.Ncd = ncd.Result;
            ViewBag.Allergies = allergies.Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(PatientViewModel model)
        {
            string patientName = model.PatientName;
            int diseaseId = model.DiseaseId;
            //List<int> ncdIds = model.NcdIds;
            await BaseApiService.PostAsync(_httpClient, "Patients", model);

            return RedirectToAction("Index");
        }

    }
}