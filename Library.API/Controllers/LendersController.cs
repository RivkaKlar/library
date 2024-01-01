using Library.Core.Models;
using Library.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendersController : ControllerBase
    {

        private readonly ILenderService _Lender;
        public LendersController(ILenderService lender)
        {
            _Lender = lender;
        }
        // GET: api/<LendersController>
        [HttpGet]
        public IEnumerable<Lend> Get()
        {
            return _Lender.GetAll();
        }

        // GET api/<LendersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LendersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LendersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LendersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
