using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_TimeSendDataController : ApiController
    {
        private readonly IM_TimeSendDataService m_TimeSendDataService;

        public M_TimeSendDataController(IM_TimeSendDataService timeSendDataService)
        {
            m_TimeSendDataService = timeSendDataService;
        }

        // GET: api/M_TimeSendData
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_TimeSendData/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_TimeSendData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_TimeSendData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_TimeSendData/5
        public void Delete(int id)
        {
        }
    }
}
