using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class JobRequestController : ApiController
    {
        private readonly IJobRequestService jobRequestService;

        public JobRequestController(IJobRequestService jobRequestService)
        {
            this.jobRequestService = jobRequestService;
        }

        // GET: api/JobRequest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/JobRequest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JobRequest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/JobRequest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/JobRequest/5
        public void Delete(int id)
        {
        }
    }
}
