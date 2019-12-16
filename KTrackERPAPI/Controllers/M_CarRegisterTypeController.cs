using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_CarRegisterTypeController : ApiController
    {
        private readonly IM_CarRegisterTypeService m_CarRegisterTypeService;

        public M_CarRegisterTypeController(IM_CarRegisterTypeService carRegisterTypeService)
        {
            m_CarRegisterTypeService = carRegisterTypeService;
        }

        // GET: api/M_CarRegisterType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_CarRegisterType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_CarRegisterType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_CarRegisterType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_CarRegisterType/5
        public void Delete(int id)
        {
        }
    }
}
