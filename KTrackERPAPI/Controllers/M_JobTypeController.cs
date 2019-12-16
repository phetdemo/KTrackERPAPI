using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_JobTypeController : ApiController
    {
        private readonly IM_JobTypeService m_JobTypeService;

        public M_JobTypeController(IM_JobTypeService jobTypeService)
        {
            m_JobTypeService = jobTypeService;
        }

        // GET: api/M_JobType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_JobType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_JobType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_JobType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_JobType/5
        public void Delete(int id)
        {
        }
    }
}
