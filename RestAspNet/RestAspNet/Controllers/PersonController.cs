using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaterController : ControllerBase
    {

        private readonly ILogger<CalculaterController> _logger;

        public CalculaterController(ILogger<CalculaterController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
      
            return BadRequest("Invalid Input");
        }
    }
}