using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects
{
    public class User
    {
        public int id { get; set; }
        public string fullname { get; set; } = "";
        public string username { get; set; } = "";
        public string email { get; set; } = "";
        public string dni { get; set; } = "";
        public Role role { get; set; }

        public override string ToString()
        {
            return username;
        }
    }
}
