using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {
     
        public Camion(string Marca, string Modelo, string Potencia, Remolque Remolque, bool CabinaDescanso) : base(Marca, Modelo)
        {
            this.Potencia = Potencia;
            this.Remolque = Remolque;
            this.CabinaDescanso = CabinaDescanso;

        }
    public string Potencia { get; set; }
        public Remolque Remolque { get; set; }
        public bool CabinaDescanso { get; set; } 

        public override string acelera()
        {
            return "Este vehiculo acelera con un motor Diesel";
        }
        public override string frena()
        {
            return "Este vehiculo frena con frenos de aire";
        }
        public string QuitarRemolque() 
        {
            if (Remolque != null) 
            {
                 this.Remolque = null;
                return "Remolque eliminado";
            } else return "El Camion no tiene ningun remolque";
        }
        public override string ToString()
        {
            if (Remolque != null) 
            {
                return base.ToString() + $", Potencia {Potencia}, CabinaDescanso: {CabinaDescanso}, Remolque Tipo: {Remolque.Tipo}";
            }
            else return base.ToString() + $", Potencia {Potencia}, CabinaDescanso: {CabinaDescanso}, Remolque: Sin  Remolque";

        }

    }
}
