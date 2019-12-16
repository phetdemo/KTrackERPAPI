using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_TypeStockController : ApiController
    {
        private readonly IM_TypeStockService m_TypeStockService;

        public M_TypeStockController(IM_TypeStockService typeStockService)
        {
            m_TypeStockService = typeStockService;
        }

        // GET: api/M_TypeStock
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_TypeStock/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_TypeStock
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_TypeStock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_TypeStock/5
        public void Delete(int id)
        {
        }
    }
}
