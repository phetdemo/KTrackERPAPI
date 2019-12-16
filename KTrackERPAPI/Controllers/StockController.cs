using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class StockController : ApiController
    {
        private readonly IStockService stockService;

        public StockController(IStockService stockService)
        {
            this.stockService = stockService;
        }

        // GET: api/Stock
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Stock/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stock
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Stock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stock/5
        public void Delete(int id)
        {
        }
    }
}
