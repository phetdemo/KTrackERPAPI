using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class StockDetailController : ApiController
    {
        private readonly IStockDetailService stockDetailService;

        public StockDetailController(IStockDetailService stockDetailService)
        {
            this.stockDetailService = stockDetailService;
        }

        // GET: api/StockDetail
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StockDetail/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StockDetail
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StockDetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StockDetail/5
        public void Delete(int id)
        {
        }
    }
}
