using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_DeviceController : ApiController
    {
        private readonly IM_DeviceService m_DeviceService;

        public M_DeviceController(IM_DeviceService deviceService)
        {
            m_DeviceService = deviceService;
        }

        // GET: api/Device
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Device/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Device
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Device/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Device/5
        public void Delete(int id)
        {
        }
    }
}
