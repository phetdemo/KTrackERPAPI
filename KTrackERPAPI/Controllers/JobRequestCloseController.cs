using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    [RoutePrefix("api/JobRequestClose")]
    public class JobRequestCloseController : ApiController
    {
        private readonly IJobRequestCloseService jobRequestcloseService;

        public JobRequestCloseController(IJobRequestCloseService jobRequestCloseService)
        {
            this.jobRequestcloseService = jobRequestCloseService;
        }
        // GET: api/JobRequestClose/5
        public IHttpActionResult Get(int id)
        {
            return Ok(jobRequestcloseService.GetById(id));
        }

        // POST: api/JobRequestClose
        [ResponseType(typeof(JobRequestClose))]
        public IHttpActionResult PostJobReqClose(JobRequestClose obj)
        {
            return Ok(jobRequestcloseService.Insert(obj));
        }
        [Route("GetJobCode")]
        [HttpGet]
        public IHttpActionResult GetJobCode()
        {
            return Ok(jobRequestcloseService.GenerateJobCode());
        }
        [Route("GetCarAndBoxByJobReqByID/{jobreqid}")]
        [HttpGet]
        public IHttpActionResult GetCarAndBoxByJobReqByID(int jobreqid)
        {
            return Ok(jobRequestcloseService.GetCarAndBoxByJobReqByID(jobreqid));
        }
        [Route("GetJobRequestInformationByJobReqID/{jobreqid}")]
        [HttpGet]
        public IHttpActionResult GetJobRequestInformationByJobReqID(int jobreqid)
        {
            return Ok(jobRequestcloseService.GetJobRequestInformationByJobReqID(jobreqid));
        }

         


    }
}
