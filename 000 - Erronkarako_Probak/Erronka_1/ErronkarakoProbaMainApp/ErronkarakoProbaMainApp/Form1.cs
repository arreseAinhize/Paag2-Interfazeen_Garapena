using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErronkarakoProbaMainApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(UserControl userControlHijo)
        {
            // Oculta los botones del menú
            pictureBox1.Visible = false;
            btnProdukt.Visible = false;
            btnBezeroak.Visible = false;
            btnGastuak.Visible = false;
            btnIrabaziak.Visible = false;

            // Limpia el panel antes de cargar el nuevo UserControl
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.RemoveAt(0);

            // Configura el UserControl hijo
            userControlHijo.Dock = DockStyle.Fill;

            // Agrega el UserControl hijo al panel
            PanelContenedor.Controls.Add(userControlHijo);
            PanelContenedor.Tag = userControlHijo;
        }
        public void LimpiarPanel()
        {
            // Limpia el contenido actual del panel (por ejemplo, el UserControl)
            PanelContenedor.Controls.Clear();

            // Vuelve a mostrar los elementos del menú principal
            pictureBox1.Visible = true;
            btnProdukt.Visible = true;
            btnBezeroak.Visible = true;
            btnGastuak.Visible = true;
            btnIrabaziak.Visible = true;

            // Los re-agregamos al panel por si se eliminaron
            if (!PanelContenedor.Controls.Contains(pictureBox1))
                PanelContenedor.Controls.Add(pictureBox1);
            if (!PanelContenedor.Controls.Contains(btnProdukt))
                PanelContenedor.Controls.Add(btnProdukt);
            if (!PanelContenedor.Controls.Contains(btnBezeroak))
                PanelContenedor.Controls.Add(btnBezeroak);
            if (!PanelContenedor.Controls.Contains(btnGastuak))
                PanelContenedor.Controls.Add(btnGastuak);
            if (!PanelContenedor.Controls.Contains(btnIrabaziak))
                PanelContenedor.Controls.Add(btnIrabaziak);

            // Opcional: traerlos al frente por si algo los cubre
            pictureBox1.BringToFront();
            btnProdukt.BringToFront();
            btnBezeroak.BringToFront();
            btnGastuak.BringToFront();
            btnIrabaziak.BringToFront();
        }

        private void btnBezeroak_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Bezeroak());
        }
    }
}
