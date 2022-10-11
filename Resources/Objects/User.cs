using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects
{
    public class User
    {
        public int id { get; set; } = 0;
        public string username { get; set; } = "";
        public string email { get; set; } = "";
        public int dni { get; set; } = 0;
        public string role { get; set; } = "";
    }
}
