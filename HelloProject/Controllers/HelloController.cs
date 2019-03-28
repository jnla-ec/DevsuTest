using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET api/hello
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/hello/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "Hello " + id.ToString() + " from a6c9cbf549bd";
        //}

        // GET api/hello/Juan
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return "Hello " + name + " from a6c9cbf549bd";
        }

        // POST api/hello
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/hello/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/hello/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
