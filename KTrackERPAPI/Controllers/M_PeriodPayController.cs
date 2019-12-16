using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_PeriodPayController : ApiController
    {
        private readonly IM_PeriodPayService m_PeriodPayService;

        public M_PeriodPayController(IM_PeriodPayService periodPayService)
        {
            m_PeriodPayService = periodPayService;
        }

        // GET: api/M_PeriodPay
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_PeriodPay/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_PeriodPay
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_PeriodPay/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_PeriodPay/5
        public void Delete(int id)
        {
        }
    }
}
