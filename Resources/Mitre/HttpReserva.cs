using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Mitre
{
    public class HttpGetReserva
    {
        public string user_id { get; set; }
        public string phone { get; set; } = "";
        public string schedule { get; set; } = "";
        public string date { get; set; } = "";
        public string selected_tables { get; set; } = "";
    }
    public class HttpPostReserva
    {
        public int user_id { get; set; }
        public string phone { get; set; } = "";
        public string schedule { get; set; } = "";
        public string date { get; set; } = "";
        public string selected_tables { get; set; } = "";
    }
}
