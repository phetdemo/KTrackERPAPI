using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_LicenceDriveTypeController : ApiController
    {
        private readonly IM_LicenceDriveTypeService m_LicenceDriveTypeService;

        public M_LicenceDriveTypeController(IM_LicenceDriveTypeService licenceDriveTypeService)
        {
            m_LicenceDriveTypeService = licenceDriveTypeService;
        }

        // GET: api/M_LicenceDriveType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_LicenceDriveType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_LicenceDriveType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_LicenceDriveType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_LicenceDriveType/5
        public void Delete(int id)
        {
        }
    }
}
