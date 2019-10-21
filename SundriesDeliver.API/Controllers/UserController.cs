using SundiresDeliverApp.Core.AppRepository;
using SundiresDeliverApp.Core.Database_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SundriesDeliver.API.Controllers
{
    public class UserController : ApiController
    {
        private ReportManager reportManager;

        public UserController()
        {
            reportManager = new ReportManager();
        }

        [HttpGet]
        [Route("api/User/GetItemCategory")]
        public List<AD_MSITMCAT> GetItemCategory()
        {
            return reportManager.GetItemCategory();
        }

    }
}
