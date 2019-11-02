using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Barrier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarrierController : ControllerBase
    {
        private Models.BarrierContext db;

        public BarrierController(Models.BarrierContext context)
        {
            db = context;
        }

        [HttpGet("houses")]
        public string Houses() {
            return db.Houses.First().Name;
        }
    }
}/