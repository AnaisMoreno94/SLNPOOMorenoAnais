using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public Remolque(string Tipo, string Capacidad, Camion Camion)
        {
            this.Tipo = Tipo;
            this.Capacidad = Capacidad;
            this.Camion = Camion;
        }

        public string Tipo { get; set; }
        public string Capacidad { get; set;}
        public Camion Camion { get; set; }

        public override string ToString()
        {
            if (Camion != null) 
            {
                return $"Tipo : {Tipo}, Capacidad: {Capacidad}, Camion : {Camion.Modelo}";
            }
            else return $"Tipo : {Tipo}, Capacidad: {Capacidad}, Camion : Sin Camion Asignado";

        }
    }
}
