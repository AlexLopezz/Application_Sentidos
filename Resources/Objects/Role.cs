using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects
{
    public class Role
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";

        public override string ToString() { return name; }

    }

}
