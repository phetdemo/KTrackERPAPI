using KTrackERP.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class FileController : ApiController
    {
        private readonly IFileService fileService;

        public FileController(IFileService fileService)
        {
            this.fileService = fileService;
        }

        // GET: api/File
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/File/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/File
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/File/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/File/5
        public void Delete(int id)
        {
        }
    }
}
