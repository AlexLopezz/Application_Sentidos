using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Roles.AdministradorFolder
{
    public class GetReserva
    {
        public int id { get; set; }
        public string schedule { get; set; }
        public string date { get; set; }
        public bool paid { get; set; }
        public bool paid_parcial { get; set; }
        public string selected_table { get; set; }
    }
}
