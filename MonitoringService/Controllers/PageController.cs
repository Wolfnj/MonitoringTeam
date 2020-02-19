using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MonitoringService.Models;

namespace MonitoringService.Controllers
{
    public class PageController : ApiController
    {


        public IEnumerable<PAGE> Get()
        {
            using (bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.PAGEs.ToList();
            }
        }
        public PAGE Get(string pageTitle)
        {
            using (bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.PAGEs.FirstOrDefault(p => p.PAGE_TITLE.Equals(pageTitle));
            }
        }


    }
}
