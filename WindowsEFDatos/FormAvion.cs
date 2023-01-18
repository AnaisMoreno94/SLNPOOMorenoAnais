using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class FormAvion : Form
    {
        public FormAvion()
        {
            InitializeComponent();
        }
        private void MostrarTodosAviones()
        {
            gridAviones.DataSource = AbmAvion.Listar();
        }

        private void btnInsertarAvion_Click(object sender, EventArgs e)
        {
            LineaAerea linea = new LineaAerea() { Nombre = "Copa" , FechaInicioActividades = new DateTime(2000,01,01)};
            Avion avion = new Avion() {Capacidad = 220,Denominacion= "Avion Comercial" , LineaAerea = linea};

            int filasAfectadas = AbmAvion.Insertar(avion);
            if (filasAfectadas > 0) {
                MessageBox.Show("Avion insertado correctamente");
                MostrarTodosAviones();
            }

        }

        private void FormAvion_Load(object sender, EventArgs e)
        {
            MostrarTodosAviones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Denominacion = txtDeno.Text, IdAvion= Convert.ToInt32(txtID.Text)};
            int filasAfectadas = AbmAvion.Editar(avion);
            if (filasAfectadas > 0) 
            {
                MessageBox.Show("Avion Editado Correctamente");
                MostrarTodosAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Avion avion = AbmAvion.TraerUno(Convert.ToInt32(txtID.Text));
            if (avion != null) 
            {
                int filasAfectadas = AbmAvion.Eliminar(avion.IdAvion);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Avion Eliminado Correctamente");
                    MostrarTodosAviones();
                }

            } else MessageBox.Show("El ID no pertenece a ningun avion existente");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Traer Uno 
            Avion avion = AbmAvion.TraerUno(Convert.ToInt32(txtID.Text));
            if (avion != null) 
            {
                MessageBox.Show(avion.ToString());
            } else MessageBox.Show("El ID no pertenece a ningun avion existente");
        }
    }
}
