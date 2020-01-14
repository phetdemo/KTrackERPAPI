using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;
using System.Web.Http.Description;

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
        public IHttpActionResult Get()
        {
            return Ok(m_EmployeeService.Get());
        }

        // GET: api/M_Employee/5
        public IHttpActionResult Get(int id)
        {
            return Ok(m_EmployeeService.GetById(id));
        }

        // POST: api/M_Employee
        [ResponseType(typeof(M_Employee))]
        public IHttpActionResult PostM_Employee(M_Employee obj)
        {
            return Ok(m_EmployeeService.Insert(obj));
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
