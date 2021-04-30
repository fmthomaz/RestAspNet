﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAspNet.Model;
using RestAspNet.Provider;

namespace RestAspNet.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonProvider _personProvider;

        public PersonController(ILogger<PersonController> logger, IPersonProvider personProvider)
        {
            _logger = logger;
            _personProvider = personProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personProvider.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = _personProvider.FindById(id);
            if(person == null) { return NotFound(); }

            return Ok(person);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Person person)
        {
          
            if (person == null) { return BadRequest(); }

            return Ok(_personProvider.Create(person));
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null) { return BadRequest(); }

            return Ok(_personProvider.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personProvider.Delete(id);            

            return NoContent();
        }

    }
}