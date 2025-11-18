using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErronkarakoProbaMainApp
{
    public partial class Bezeroak : UserControl
    {
        public Bezeroak()
        {
            InitializeComponent();
            chart1.Visible = true;
            chart2.Visible = true;
            btnBack.Visible = true;
            btnGastuak.Visible = true;
            btnIrabaziak.Visible = true;
            btnProduk.Visible = true;
            pictureBox1.Visible = true;
            dataGridView1.Visible = true;
            btnBack.Click += BtnBack_Click;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal abierto (por nombre de clase)
            var main = (Form1)Application.OpenForms["Form1"];

            if (main != null)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                btnBack.Visible = false;
                btnGastuak.Visible = false;
                btnIrabaziak.Visible = false;
                btnProduk.Visible = false;
                pictureBox1.Visible = false;
                dataGridView1.Visible = false;
                // Limpia el panel contenedor para volver al menú inicial
                main.LimpiarPanel();
            }
            
        }
    }
}
