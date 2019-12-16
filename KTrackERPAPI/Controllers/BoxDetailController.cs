using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class BoxDetailController : ApiController
    {
        private readonly IBoxDetailService boxDetailService;
        public BoxDetailController(IBoxDetailService boxDetailService)
        {
            this.boxDetailService = boxDetailService;
        }

        // GET: api/BoxDetail
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BoxDetail/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BoxDetail
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BoxDetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BoxDetail/5
        public void Delete(int id)
        {
        }
    }
}
