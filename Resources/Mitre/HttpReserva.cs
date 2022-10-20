using Application_Sentidos.Resources.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Mitre
{
    public class HttpGetReserva
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public string phone { get; set; } = "";
        public string schedule { get; set; } = "";
        public string date { get; set; } = "";
        public List<SelectedTable> selected_tables { get; set; }

        public override string ToString()
        {
            return user_id.ToString();
        }
    }
    public class HttpPostReserva
    {
        public int user_id { get; set; }
        public string phone { get; set; } = "";
        public string schedule { get; set; } = "";
        public string date { get; set; } = "";
        public List<int> selected_tables { get; set; }
    }
    public class GetUserFilter
    {
        public int id { get; set; }
        public string username { get; set; }

        public override string ToString()
        {
            return id+" "+username;
        }
    }
    public class GetSelectedTable
    {
        public List<SelectedTable> selected_tables { get; set; }
    }
    public class SelectedTable
    {
        public int id { get; set; }
        public int number_mesa { get; set; }
    }

    



}
