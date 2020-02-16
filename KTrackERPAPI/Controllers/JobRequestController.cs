using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    [RoutePrefix("api/JobRequest")]
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
        public IHttpActionResult Get(int id)
        {
            return Ok(jobRequestService.GetById(id));
        }

        // POST: api/JobRequest
        [ResponseType(typeof(JobRequest))]
        public IHttpActionResult PostJobReq(JobRequest obj)
        {
            return Ok(jobRequestService.Insert(obj));
        }

        // PUT: api/JobRequest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/JobRequest/5
        public void Delete(int id)
        {
        }


        [Route("GetWorklist/{jobstatusID}")]
        [HttpGet]
        public IHttpActionResult GetWorklist(int jobstatusID)
        {
            return Ok(jobRequestService.GetJobWorkList(jobstatusID));
        }

        [Route("GetJobCode/{jobtype}")]
        [HttpGet]
        public IHttpActionResult GetJobCode(string jobtype)
        {
            return Ok(jobRequestService.GenerateJobCode(jobtype));
        }
        [Route("GetHistoryJob/{jobstatus}")]
        [HttpGet]
        public IHttpActionResult GetHistoryJob(int jobstatus)
        {
            return Ok(jobRequestService.GetHistoryJob(jobstatus));
        }
    }
}
