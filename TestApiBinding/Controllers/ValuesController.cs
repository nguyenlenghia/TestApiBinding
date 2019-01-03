using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApiBinding.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]DateTime? value)
        {
            return Ok(new
            {
                Data = value
            });
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        // POST api/TestMultiParams
        [Route("api/TestMultiParams")]
        [HttpPost]
        //[AcceptVerbs(HttpMethod.Post)]
        [Common.MultiParameterSupport]
        public IHttpActionResult TestMultiParams(string value1, string value2)
        {
            return Ok(new
            {
                value1 = value1,
                value2 = value2
            });
        }
    }
}
