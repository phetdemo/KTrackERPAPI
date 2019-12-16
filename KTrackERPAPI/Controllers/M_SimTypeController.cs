using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_SimTypeController : ApiController
    {
        private readonly IM_SimTypeService m_SimTypeService;

        public M_SimTypeController(IM_SimTypeService simTypeService)
        {
            m_SimTypeService = simTypeService;
        }

        // GET: api/M_SimType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_SimType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_SimType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_SimType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_SimType/5
        public void Delete(int id)
        {
        }
    }
}
