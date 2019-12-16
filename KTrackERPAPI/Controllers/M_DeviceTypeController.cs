using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_DeviceTypeController : ApiController
    {
        private readonly IM_DeviceTypeService m_DeviceTypeService;

        public M_DeviceTypeController(IM_DeviceTypeService deviceTypeService)
        {
            m_DeviceTypeService = deviceTypeService;
        }

        // GET: api/M_DeviceType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_DeviceType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_DeviceType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_DeviceType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_DeviceType/5
        public void Delete(int id)
        {
        }
    }
}
