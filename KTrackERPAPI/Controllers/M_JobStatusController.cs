using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_JobStatusController : ApiController
    {
        private readonly IM_JobStatusService m_JobStatusService;

        public M_JobStatusController(IM_JobStatusService jobStatusService)
        {
            m_JobStatusService = jobStatusService;
        }

        // GET: api/M_JobStatus
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_JobStatus/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_JobStatus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_JobStatus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_JobStatus/5
        public void Delete(int id)
        {
        }
    }
}
