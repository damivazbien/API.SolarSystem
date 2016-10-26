using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    public class SolarSystemController : Controller
    {
        private readonly ISolarSystem _systemSolar;

        public SolarSystemController(ISolarSystem systemSolar)
        {
            _systemSolar = systemSolar;
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_systemSolar.Get());
        }
    }
}