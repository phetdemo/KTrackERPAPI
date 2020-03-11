using KTrackERP.Entity;
using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    [RoutePrefix("api/Box")]
    public class BoxController : ApiController
    {
        private readonly IBoxService boxService;

        public BoxController(IBoxService boxService)
        {
            this.boxService = boxService;
        }

        // GET: api/Box
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Box/5
        public IHttpActionResult Get(int id)
        {
            return Ok(boxService.GetbyId(id));
        }

        // POST: api/Box
        [ResponseType(typeof(Box))]
        public IHttpActionResult PostBox(Box obj)
        {
            return Ok(boxService.Insert(obj));
        }
        [Route("GetBoxByJobID/{JobID}")]
        [HttpGet]
        public IHttpActionResult GetBoxByJobID(int JobID)
        {
            return Ok(boxService.GetBoxByJobID(JobID));
        }

        // PUT: api/Box/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Box/5
        public void Delete(int id)
        {
        }
    }
}
