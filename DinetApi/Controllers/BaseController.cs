using DinetUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DinetApi.Controllers
{
    public class BaseController : ApiController
    {
        protected UnitOfWork unitOfWork;
        
        public BaseController()
        {
            unitOfWork = new UnitOfWorkImp();
        }
    }
}
