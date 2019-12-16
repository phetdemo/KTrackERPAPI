using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_AccessoriesController : ApiController
    {
        private readonly IM_AccessoriesService m_AccessoriesService;

        public M_AccessoriesController(IM_AccessoriesService accessoriesService)
        {
            m_AccessoriesService = accessoriesService;
        }

        // GET: api/M_Accessories
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_Accessories/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_Accessories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_Accessories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_Accessories/5
        public void Delete(int id)
        {
        }
    }
}
