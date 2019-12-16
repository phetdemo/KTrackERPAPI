using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_PositionController : ApiController
    {
        private readonly IM_PositionService m_PositionService;

        public M_PositionController(IM_PositionService positionService)
        {
            m_PositionService = positionService;
        }

        // GET: api/M_Position
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_Position/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_Position
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_Position/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_Position/5
        public void Delete(int id)
        {
        }
    }
}
