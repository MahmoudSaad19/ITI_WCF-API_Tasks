using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFirstLook.Controllers
{
    public class DefaultController : ApiController
    {
        public string GetHello()
        {
            return "Hello API From Get Hello";
        }

        //public string Get()
        //{
        //    return "Hello API from Get";
        //}
    }
}
