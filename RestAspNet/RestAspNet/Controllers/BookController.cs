using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAspNet.Model;
using RestAspNet.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNet.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {

         private readonly ILogger<BookController> _logger;
        private IBookProvider _bookProvider;

        public BookController(ILogger<BookController> logger, IBookProvider bookProvider)
        {
            _logger = logger;
            _bookProvider = bookProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookProvider.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookProvider.FindById(id);
            if (book == null) { return NotFound(); }

            return Ok(book);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Book book)
        {

            if (book == null) { return BadRequest(); }

            return Ok(_bookProvider.Create(book));
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) { return BadRequest(); }

            return Ok(_bookProvider.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookProvider.Delete(id);

            return NoContent();
        }
    }
}
