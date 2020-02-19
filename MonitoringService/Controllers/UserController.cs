using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MonitoringService.Models;

namespace MonitoringService.Controllers
{
    public class UserController : ApiController
    {

        public IEnumerable<USER> Get()
        {
            using(bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.USERs.ToList();
            }
        }
        public USER Get(string userName)
        {
            using(bikeshopdatabaseEntities dbContext = new bikeshopdatabaseEntities())
            {
                return dbContext.USERs.FirstOrDefault(u => u.USERNAME.Equals(userName));
            }
        }

    }
}
