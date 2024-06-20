using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "It changed again and again!";
        }
    }
}