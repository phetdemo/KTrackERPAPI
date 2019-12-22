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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Master_H/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Master_H/5
        public void Delete(int id)
        {
        }
    }
}
