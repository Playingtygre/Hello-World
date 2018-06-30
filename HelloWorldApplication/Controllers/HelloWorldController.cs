using System.Collections.Generic;
using System.Web.Http;
using HelloWorldApplication.Models;


/* the Web API controller that will handle the http request
 */

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

        /*
         *CREATE, UPDATE, AND DELETE METHODS CAN GO HERE
         */

    }
}
