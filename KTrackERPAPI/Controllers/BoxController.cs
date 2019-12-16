using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class BoxController : ApiController
    {
        private readonly IBoxService boxService;

        public BoxController(IBoxService boxService)
        {
            this.boxService = boxService;
        }

        // GET: api/Box
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Box/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Box
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Box/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Box/5
        public void Delete(int id)
        {
        }
    }
}
