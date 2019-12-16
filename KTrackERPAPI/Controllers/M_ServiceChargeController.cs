using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_ServiceChargeController : ApiController
    {
        private readonly IM_ServiceChargeService m_ServiceChargeService;

        public M_ServiceChargeController(IM_ServiceChargeService serviceChargeService)
        {
            m_ServiceChargeService = serviceChargeService;
        }

        // GET: api/M_ServiceCharge
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_ServiceCharge/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_ServiceCharge
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_ServiceCharge/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_ServiceCharge/5
        public void Delete(int id)
        {
        }
    }
}
