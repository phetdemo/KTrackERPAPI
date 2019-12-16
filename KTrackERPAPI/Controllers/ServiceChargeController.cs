using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class ServiceChargeController : ApiController
    {
        private readonly IServiceChargeService serviceChargeService;

        public ServiceChargeController(IServiceChargeService serviceChargeService)
        {
            this.serviceChargeService = serviceChargeService;
        }

        // GET: api/ServiceCharge
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ServiceCharge/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ServiceCharge
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ServiceCharge/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ServiceCharge/5
        public void Delete(int id)
        {
        }
    }
}
