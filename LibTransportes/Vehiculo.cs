using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {
        public Vehiculo(string Marca, string Modelo) 
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        //Existe Polimorfismo en sus metodos ya que los veiculos aceleran y frenan de maneras distintas
        public abstract string acelera();
        public abstract string frena();
        public override string ToString()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}";
        }
    }
}
