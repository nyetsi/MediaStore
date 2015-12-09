using System.Collections.Generic;
using System.Web.Http;

namespace Media.Controllers
{
    public class MediaController : ApiController
    {
        // GET api/media
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/media/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/media
        public void Post([FromBody]string value)
        {
        }

        // PUT api/media/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/media/5
        public void Delete(int id)
        {
        }
    }
}
