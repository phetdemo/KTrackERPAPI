using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;

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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Master_H
        public IHttpActionResult Post(Master_H obj)
        {
            return Ok(master_HService.Insert(obj));
        }

        // DELETE: api/Master_H/5
        public void Delete(int id)
        {
        }
    }
}
