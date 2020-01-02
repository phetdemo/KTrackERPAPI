using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    public class Master_HController : ApiController
    {
        private readonly IMaster_HService master_HService;

        public Master_HController(IMaster_HService master_HService)
        {
            this.master_HService = master_HService;
        }

        // GET: api/Master_H
        public IHttpActionResult Get()
        {
            return Ok(master_HService.Get());
        }

        // GET: api/Master_H/5
        public IHttpActionResult Get(string id)
        {
            return Ok(master_HService.GetbyId(id));
        }

        // POST: api/Master_H
        [ResponseType(typeof(Master_H))]
        public IHttpActionResult PostMaster_H(Master_H obj)
        {
            return Ok(master_HService.Insert(obj));
        }

        // DELETE: api/Master_H/5
        public void Delete(int id)
        {
        }
    }
}
