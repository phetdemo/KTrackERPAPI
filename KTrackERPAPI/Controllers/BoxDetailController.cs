using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    public class BoxDetailController : ApiController
    {
        private readonly IBoxDetailService boxDetailService;
        public BoxDetailController(IBoxDetailService boxDetailService)
        {
            this.boxDetailService = boxDetailService;
        }

        // GET: api/BoxDetail
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BoxDetail/5
        public IHttpActionResult Get(int id)
        {
            return Ok(boxDetailService.GetbyId(id));
        }

        // POST: api/BoxDetail
        [ResponseType(typeof(BoxDetail))]
        public IHttpActionResult PostBoxDetail(BoxDetail obj)
        {
            return Ok(boxDetailService.Insert(obj));
        }

        // PUT: api/BoxDetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BoxDetail/5
        public void Delete(int id)
        {
        }
    }
}
