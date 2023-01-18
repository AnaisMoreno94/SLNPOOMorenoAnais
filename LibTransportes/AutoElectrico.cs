using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico:Vehiculo
    {
        public AutoElectrico(string Marca, string Modelo, int Carga, string TipoEnchufe) : base(Marca , Modelo)
        {
            this.Carga= Carga;
            this.Modelo= Modelo;
      
        }
        public int Carga { get; set; }
        public string TipoEnchufe { get; set; }


        public override string  acelera() 
        {
           return "Este vehiculo acelera con un motor electrico";
        }
        public override string frena()
        {
            return "Este vehiculo frena con frenos de disco";
        }
        public override string ToString()
        {
            return base.ToString() + $", Carga {Carga}, TipoEnchufe: {TipoEnchufe} ";
        }

    }
}
