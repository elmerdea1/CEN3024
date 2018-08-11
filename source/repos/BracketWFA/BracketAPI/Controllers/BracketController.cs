using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BracketAccess;

namespace BracketAPI.Controllers
{
    public class BracketController : ApiController
    {

        public IEnumerable<Person> Get()
        {
            using (BracketDBEntities entities = new BracketDBEntities())
            {
                //AppDomain.CurrentDomain.SetData("DataDirectory", "C:\\Users\\Elmer Dea\\source\\repos\\BracketWFA\\BracketAccess");
                return entities.People.ToList();
            }
        }
        public Person Get(int id)
        {
            using (BracketDBEntities entities = new BracketDBEntities())
            {
                return entities.People.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
