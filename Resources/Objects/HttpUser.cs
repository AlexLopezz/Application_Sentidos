using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects
{
    //Utilizamos para: Registro de usuario.
    public class HttpUser
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
    public class Role
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";

        public override string ToString() { return name; }

    }


    //Utilizamos para: Login de Usuarios
    public class PostLogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
