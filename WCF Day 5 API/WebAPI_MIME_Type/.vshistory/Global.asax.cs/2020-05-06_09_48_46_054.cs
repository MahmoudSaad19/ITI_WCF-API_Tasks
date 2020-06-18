using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAPI_MIME_Type
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //enable all areas
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
