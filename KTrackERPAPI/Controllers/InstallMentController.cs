using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class InstallMentController : ApiController
    {
        private readonly IInstallMentService installMentService;

        public InstallMentController(IInstallMentService installMentService)
        {
            this.installMentService = installMentService;
        }

        // GET: api/InstallMent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/InstallMent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/InstallMent
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/InstallMent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/InstallMent/5
        public void Delete(int id)
        {
        }
    }
}
