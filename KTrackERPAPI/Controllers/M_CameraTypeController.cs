using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_CameraTypeController : ApiController
    {
        private readonly IM_CameraTypeService m_CameraTypeService;

        public M_CameraTypeController(IM_CameraTypeService cameraTypeService)
        {
            m_CameraTypeService = cameraTypeService;
        }

        // GET: api/M_CameraType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_CameraType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_CameraType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_CameraType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_CameraType/5
        public void Delete(int id)
        {
        }
    }
}
