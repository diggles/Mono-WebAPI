using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PeopleController : ApiController
    {
   
        // GET: People
        public object GetPeople()
        {
            return new List<Person>()
            {
                new Person() { Name = "Jim" },
                new Person() { Name = "Bob" },
                new Person() { Name = "Jane" }
            }.ToList();
        }
        /*
     
         */
    }
}
