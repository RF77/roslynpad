using System.Collections.Generic;
using System.Web.Http;
using RoslynPadLib.Roslyn;

namespace RoslynPadHost.Controllers
{
    public class CompletionController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/values/5 
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values 
        public object Post([FromBody]RoslynData value)
        {
            return Json(value);
        }

        //// PUT api/values/5 
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5 
        //public void Delete(int id)
        //{
        //}
    }
}