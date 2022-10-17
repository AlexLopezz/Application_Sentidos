using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Administrador.Modificar_Form_Objects
{
    public class PostModify
    {
        public int id { get; set; } = 0;
        public string username { get; set; } = "";
        public string email { get; set; } = "";
        public string fullname { get; set; } = "";
        public int dni { get; set; } = 0;
        public string password { get; set; } = "";
        public int role { get; set; }
    }
}
