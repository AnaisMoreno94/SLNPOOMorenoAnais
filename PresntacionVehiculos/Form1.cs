using LibTransportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresntacionVehiculos
{
    public partial class btnCrearCamionRemolque : Form
    {
        public btnCrearCamionRemolque()
        {
            InitializeComponent();
        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Mercedez Benz", "Arocs 1833A", "1600rpm", null, false);
            MessageBox.Show(camion.ToString());
        }

        private void btnCrearRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque("Grua","Un auto",null);
            MessageBox.Show(remolque.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Mercedez Benz", "Arocs 1833A", "1600rpm", null, false);
            Remolque remolque = new Remolque("Grua", "Un auto", camion);
            
            camion.Remolque= remolque;

            MessageBox.Show(camion.ToString());

        }
    }
}
