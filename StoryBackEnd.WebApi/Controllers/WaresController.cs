using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoryBackEnd.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaresController : ControllerBase
    {
        public  IActionResult getAllWare()
        {
            var list = new List<string>
            {
                "book",
                "pencil",
                "robot"
            };

            return Ok(new { list = list });
        }
    }
}