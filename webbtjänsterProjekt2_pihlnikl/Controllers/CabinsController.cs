using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webbtjänsterProjekt2_pihlnikl.Models;
using webbtjänsterProjekt2_pihlnikl.Services;

namespace webbtjänsterProjekt2_pihlnikl.Controllers
{
    [Route("cabins")]
    [ApiController]
    public class CabinsController : ControllerBase
    {
        private readonly CabinServices _cabinService;

        public CabinsController(CabinServices cabinService)
        {
            _cabinService = cabinService;
        }

        [HttpGet]
        public ActionResult<List<Cabin>> GetCabin() =>
            _cabinService.Get();

        [HttpGet("{owner}", Name = "GetCabin")]
        public ActionResult<List<Cabin>> Get(string owner)
        {
            var cab = _cabinService.Get(owner);

            if (cab == null)
            {
                return NotFound();
            }

            return cab;
        }

    }
}