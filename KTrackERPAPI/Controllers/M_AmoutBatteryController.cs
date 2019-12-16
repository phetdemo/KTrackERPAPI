using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_AmoutBatteryController : ApiController
    {
        private readonly IM_AmountBatteryService m_AmountBatteryService;

        public M_AmoutBatteryController(IM_AmountBatteryService amountBatteryService)
        {
            m_AmountBatteryService = amountBatteryService;
        }

        // GET: api/M_AmoutBattery
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_AmoutBattery/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_AmoutBattery
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_AmoutBattery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_AmoutBattery/5
        public void Delete(int id)
        {
        }
    }
}
