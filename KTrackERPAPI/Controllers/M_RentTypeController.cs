using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_RentTypeController : ApiController
    {
        private readonly IM_RentTypeService m_RentTypeService;

        public M_RentTypeController(IM_RentTypeService rentTypeService)
        {
            m_RentTypeService = rentTypeService;
        }

        // GET: api/M_RentType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_RentType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_RentType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_RentType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_RentType/5
        public void Delete(int id)
        {
        }
    }
}
