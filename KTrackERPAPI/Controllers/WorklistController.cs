using KTrackERP.Service.Interface;
using System.Web.Http;

namespace KTrackERPAPI.Controllers
{
    public class WorklistController : ApiController
    {
        private readonly IJobRequestService jobRequestService;

        public WorklistController(IJobRequestService jobRequestService)
        {
            this.jobRequestService = jobRequestService;
        }

    }
}
