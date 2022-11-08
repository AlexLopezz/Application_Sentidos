using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects;

//Utilizamos para: Listar reservas.
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
//Utilizamos para: Reservar una reserva.
public class HttpPostReserva
{
    public int user_id { get; set; }
    public string phone { get; set; } = "";
    public string schedule { get; set; } = "";
    public string date { get; set; } = "";
    public bool paid { get; set; } = false;
    public List<int> selected_tables { get; set; }
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


//Utilizamos para: Buscar los usuarios.
public class GetUserFilter
{
    public int id { get; set; }
    public string username { get; set; }

    public override string ToString()
    {
        return id+" Usuario: "+username.ToUpper();
    }
}
public class PutReservaPaid
{
    public bool paid { get; set; }
}




