using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Javascript_Olarte.Controllers
{
    public class JavascriptController : ApiController
    {
        // GET: api/Javascript
        public string POST(string name, string age, string color)
        {
            string message ="Hi my name is " + name + ", my age is " + age + " and my favorite color is " + color;
            return message;
        }

        // GET: api/Javascript/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Javascript
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Javascript/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Javascript/5
        public void Delete(int id)
        {
        }
    }
}
