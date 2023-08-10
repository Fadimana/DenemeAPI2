using Business.Layer.Interface;
using DataAccess.Layer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Deneme5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakülteController : ControllerBase
    {
        private readonly IFakülteBusinessServices _fakülteBusinessServices;

        public FakülteController(IFakülteBusinessServices fakülteBusinessServices)
        {
            _fakülteBusinessServices = fakülteBusinessServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var g = await _fakülteBusinessServices.GetAllFakülte();
            if (g == null)
            {
                return NotFound();
            }
            return Ok(g);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Fakülte fakülte)
        {
            var p = await _fakülteBusinessServices.CreateFakülte(fakülte);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetID(int id)
        {
            var g = await _fakülteBusinessServices.GetFakülte(id);
            if (g == null)
            {
                return NotFound();
            } 
            return Ok(g);
        }



    }
}
