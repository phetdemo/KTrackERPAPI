using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_SoundAlertController : ApiController
    {
        private readonly IM_SoundAlertService m_SoundAlertService;

        public M_SoundAlertController(IM_SoundAlertService soundAlertService)
        {
            m_SoundAlertService = soundAlertService;
        }

        // GET: api/M_SoundAlert
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_SoundAlert/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_SoundAlert
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_SoundAlert/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_SoundAlert/5
        public void Delete(int id)
        {
        }
    }
}
