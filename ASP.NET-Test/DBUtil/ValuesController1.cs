using System.Collections.Generic;
using System.Web.Http;

namespace ASP.NET_Test.DBUtil
{
    public class ValuesController1 : ApiController
    {
        Managetest mymanager= new Managetest();
        
        // GET api/<controller>
        public string GetTest()
        {
            return mymanager.GetAllGuest();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}