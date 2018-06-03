using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.API.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    public class HelloWorldController : System.Web.Http.ApiController
    {
        // GET: HelloWorld
        [System.Web.Mvc.HttpGet]
        public string Get()
        {
            return "Hello World";
        }

    }
}