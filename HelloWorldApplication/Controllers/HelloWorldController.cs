using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldApplication.Models;

namespace HelloWorldApplication.Controllers
{
    public class HelloWorldController : ApiController
    {
        HelloWorldModel[] sayhello = new HelloWorldModel[]
        {
            new HelloWorldModel {Name = " Hello World"},
            new HelloWorldModel {Name = " Hello World"},
        };

        public IEnumerable<HelloWorldModel> GetHelloWorld()
        {
            return sayhello;
        }

        /* CREATE, UPDATE, AND DELETE METHODS CAN GO HERE
         */

    }
}
