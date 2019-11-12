using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

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
            _name = "stimming";
        }
    }
}