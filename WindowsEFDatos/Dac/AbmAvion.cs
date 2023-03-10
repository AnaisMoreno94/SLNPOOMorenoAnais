using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }
        public static int Insertar(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }
        public static int Eliminar(int Id)
        {
            Avion avionAEliminar = context.Aviones.Find(Id);
            context.Aviones.Remove(avionAEliminar);
            return context.SaveChanges();
        }

        public static int Editar(Avion avion)
        {
            Avion avionAEditar = context.Aviones.Find(avion.IdAvion);
            avionAEditar.Denominacion = avion.Denominacion;
            return context.SaveChanges();
        }

        public static Avion TraerUno(int Id)
        {
            return context.Aviones.Find(Id);
        }
    }
}
