using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class Master_DController : ApiController
    {
        private readonly IMaster_DService master_DService;

        public Master_DController(IMaster_DService master_DService)
        {
            this.master_DService = master_DService;
        }

        // GET: api/Master_D
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Master_D/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Master_D
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Master_D/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Master_D/5
        public void Delete(int id)
        {
        }
    }
}
