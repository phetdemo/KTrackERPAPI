using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    public class CarController : ApiController
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: api/Car
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Car/5
        public IHttpActionResult Get(int id)
        {
            return Ok(carService.GetById(id));
        }

        // POST: api/Car
        [ResponseType(typeof(Car))]
        public IHttpActionResult PostCar(Car obj)
        {
            return Ok(carService.Insert(obj));
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}
