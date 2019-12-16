using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_LimitSpeedController : ApiController
    {
        private readonly IM_LimitSpeedService m_LimitSpeedService;

        public M_LimitSpeedController(IM_LimitSpeedService limitSpeedService)
        {
            m_LimitSpeedService = limitSpeedService;
        }

        // GET: api/M_LimitSpeed
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_LimitSpeed/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_LimitSpeed
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_LimitSpeed/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_LimitSpeed/5
        public void Delete(int id)
        {
        }
    }
}
