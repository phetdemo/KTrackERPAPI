using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_PayBillController : ApiController
    {
        private readonly IM_PayBillService m_PayBillService;

        public M_PayBillController(IM_PayBillService payBillService)
        {
            m_PayBillService = payBillService;
        }

        // GET: api/M_PayBill
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_PayBill/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_PayBill
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_PayBill/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_PayBill/5
        public void Delete(int id)
        {
        }
    }
}
