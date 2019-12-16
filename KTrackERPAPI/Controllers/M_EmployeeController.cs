using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class M_EmployeeController : ApiController
    {
        private readonly IM_EmployeeService m_EmployeeService;

        public M_EmployeeController(IM_EmployeeService employeeService)
        {
            m_EmployeeService = employeeService;
        }

        // GET: api/M_Employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/M_Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/M_Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/M_Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/M_Employee/5
        public void Delete(int id)
        {
        }
    }
}
