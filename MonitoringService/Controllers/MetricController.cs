using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MonitoringService.Models;

namespace MonitoringService.Controllers
{
    public class MetricController : ApiController
    {

        public IEnumerable<METRIC> Get()
        {
            using (bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.METRICS.ToList();
            }
        }
        public METRIC Get(string sessionID)
        {
            using (bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.METRICS.FirstOrDefault(m => m.SESSION_ID.Equals(sessionID));
            }
        }



    }
}
