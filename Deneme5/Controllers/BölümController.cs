using Business.Layer.Contrete;
using Business.Layer.Interface;
using DataAccess.Layer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Deneme5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BölümController : ControllerBase
    {
        private readonly IBölümBusinessServices _bölümBusinessServices;

        public BölümController(IBölümBusinessServices bölümBusinessServices)
        {
            _bölümBusinessServices = bölümBusinessServices;

        }
        [HttpPost("Create")]
        public async Task<IActionResult> Post(string bölümname, int fakülteid)
        {
            var p = await _bölümBusinessServices.CreateBölüm(bölümname, fakülteid);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);

        }
        [HttpGet("Show")]
        public async Task<IActionResult> Get()
        {
            var g = await _bölümBusinessServices.GetAllBölüm();
            return Ok(g);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetID(int id)
        {
            var gI = await _bölümBusinessServices.GetBölüm(id);
            if(gI == null)
            {
                return BadRequest("Bulunamadı !");
            }
            return Ok(gI);
        }


    }
}
