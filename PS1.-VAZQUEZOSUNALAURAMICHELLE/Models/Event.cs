using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1._VAZQUEZOSUNALAURAMICHELLE.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public City IdCiudad { get; set; }
        public string Seguridad { get; set; }
        public DateTime FechaEventoInicio { get; set; }
        public DateTime FechaEventoFinal { get; set; }

    }
}