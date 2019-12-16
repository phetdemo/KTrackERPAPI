using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_CarBrandController : ApiController
    {
        private readonly IM_CarBrandService m_CarBrandService;

        public M_CarBrandController(IM_CarBrandService carBrandService)
        {
            m_CarBrandService = carBrandService;
        }

        // GET: api/M_CarBrand
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_CarBrand/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_CarBrand
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_CarBrand/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_CarBrand/5
        public void Delete(int id)
        {
        }
    }
}
