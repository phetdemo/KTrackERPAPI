using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Service.Interface;
using System.Web.Http;
using System.Web.Http.Description;

namespace KTrackERPAPI.Controllers
{
    [RoutePrefix("api/Requsition")]
    public class RequsitionController : ApiController
    {
        private readonly IHStockService hStockService;
        private readonly IHStockDetailService hStockDetailService;

        public RequsitionController(IHStockService hStockService)
        {
            this.hStockService = hStockService;
        }
        public RequsitionController(IHStockDetailService hStockDetailService)
        {
            this.hStockDetailService = hStockDetailService;
        }

        // POST: api/Requsition
        [ResponseType(typeof(HStock))]
        public IHttpActionResult PostHStockReq(HStock obj)
        {
            return Ok(hStockService.Insert(obj));
        }
        // GET: api/Requsition/5
        public IHttpActionResult Get(int id)
        {
            return Ok(hStockService.GetById(id));
        }
    }
}
