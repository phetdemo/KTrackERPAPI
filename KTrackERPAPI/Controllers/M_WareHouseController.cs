using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_WareHouseController : ApiController
    {
        private readonly IM_WareHouseService m_WareHouseService;

        public M_WareHouseController(IM_WareHouseService wareHouseService)
        {
            m_WareHouseService = wareHouseService;
        }

        // GET: api/M_WareHouse
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_WareHouse/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_WareHouse
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_WareHouse/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_WareHouse/5
        public void Delete(int id)
        {
        }
    }
}
