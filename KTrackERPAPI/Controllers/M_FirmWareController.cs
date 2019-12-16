using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_FirmWareController : ApiController
    {
        private readonly IM_FirmWareService m_FirmWareService;

        public M_FirmWareController(IM_FirmWareService firmWareService)
        {
            m_FirmWareService = firmWareService;
        }

        // GET: api/M_FirmWare
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_FirmWare/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_FirmWare
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_FirmWare/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_FirmWare/5
        public void Delete(int id)
        {
        }
    }
}
