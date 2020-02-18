using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    [RoutePrefix("api/Master_D")]
    public class Master_DController : ApiController
    {
        private readonly IMaster_DService master_DService;

        public Master_DController(IMaster_DService master_DService)
        {
            this.master_DService = master_DService;
        }


        // GET: api/Master_D
        public IHttpActionResult Get()
        {
            return Ok(master_DService.Get());
        }

        // GET: api/Master_D/5
        public IHttpActionResult GetById(string id)
        {
            return Ok(master_DService.GetbyId(id));
        }

        // POST: api/Master_D
        [ResponseType(typeof(Master_D))]
        public IHttpActionResult PostMaster_H(Master_D master_D)
        {
            return Ok(master_DService.Insert(master_D));
        }

        // PUT: api/Master_D/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Master_D/5
        public void Delete(int id)
        {
        }
        [Route("GetMasterType/{prmtyp}")]
        [HttpGet]
        public IHttpActionResult GetMasterType(string prmtyp)
        {
            return Ok(master_DService.GetMasterType(prmtyp));
        }
        [Route("GetOptionBox/{boxid}")]
        [HttpGet]
        public IHttpActionResult GetOptionBox(int boxid)
        {
            return Ok(master_DService.GetOptionBox(boxid));
        }
    }
}
