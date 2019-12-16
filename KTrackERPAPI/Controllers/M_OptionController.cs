using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_OptionController : ApiController
    {
        private readonly IM_OptionService m_OptionService;

        public M_OptionController(IM_OptionService optionService)
        {
            m_OptionService = optionService;
        }

        // GET: api/M_Option
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_Option/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_Option
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_Option/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_Option/5
        public void Delete(int id)
        {
        }
    }
}
