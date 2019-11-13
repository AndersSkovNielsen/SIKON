using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using ASP.NET_Test.DBUtil;

namespace ASP.NET_Test.Models
{
    public class lecture
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        

        public lecture()
        {
            Managetest ym= new Managetest();
            _name = ym.GetAllGuest();
        }
    }
}