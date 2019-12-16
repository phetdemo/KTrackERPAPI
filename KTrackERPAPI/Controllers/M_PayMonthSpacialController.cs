using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_PayMonthSpacialController : ApiController
    {
        private readonly IM_PayMonthSpacialService m_PayMonthSpacialService;

        public M_PayMonthSpacialController(IM_PayMonthSpacialService payMonthSpacialService)
        {
            m_PayMonthSpacialService = payMonthSpacialService;
        }

        // GET: api/M_PayMonthSpacial
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_PayMonthSpacial/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_PayMonthSpacial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_PayMonthSpacial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_PayMonthSpacial/5
        public void Delete(int id)
        {
        }
    }
}
