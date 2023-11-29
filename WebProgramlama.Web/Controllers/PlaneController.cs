using Microsoft.AspNetCore.Mvc;
using WebProgramlama.Entity.Entities.TripEntities;
using WebProgramlama.Service.Repositories.IRepository.ITripRepository.Plane;

namespace WebProgramlama.Web.Controllers
{
    public class PlaneController : Controller
    {
        private readonly IPlaneWriteRepository _planeWriteRepository;
        Plane p = new Plane() {Id="1", PlaneModel="3" };
        
        
        
        public PlaneController(IPlaneWriteRepository planeWriteRepository)
        {

            _planeWriteRepository = planeWriteRepository;

        }
        
        
            
        public async Task<IActionResult> Index()
        {
        await    _planeWriteRepository.AddAsync(p);
        await    _planeWriteRepository.SaveAsync();
            
            return View();
        }
    }
}
