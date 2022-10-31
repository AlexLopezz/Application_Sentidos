using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Roles.AdministradorFolder
{
    public class HttpGetContact
    {
        public string fullname { get; set; } = "";
        public string email { get; set; } = "";
        public string message { get; set; } = "";
        public string phone { get; set; } = "";
    }
    public class HttpGetAverage
    {
        public int atenttion { get; set; }
        public int place { get; set; }
        public int food { get; set; }
        public int price { get; set; }

    }
}
