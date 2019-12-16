using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_UnitController : ApiController
    {
        private readonly IM_UnitService m_UnitService;

        public M_UnitController(IM_UnitService unitService)
        {
            m_UnitService = unitService;
        }

        // GET: api/M_Unit
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_Unit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_Unit
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_Unit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_Unit/5
        public void Delete(int id)
        {
        }
    }
}
