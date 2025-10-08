using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda;
using AgendaGrafikoa;

namespace AgendaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            agendaGrafikoa1.Marraztu(Kontaktua.kontaktuak);
            dataGridView1.DataSource = Kontaktua.kontaktuakBistaratu();
        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            try
            {
                Kontaktua.kontaktuakGehitu(tbIzena.Text, tbAbizena.Text, int.Parse(tbTelefonoa.Text), cbGeneroa.Text, int.Parse(tbPrefijoa.Text));
                
                MessageBox.Show("Kontaktua ondo gehitu da!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }

        }

        private void btnIkusi_Click(object sender, EventArgs e)
        {
            taulaGarbitu();
            foreach (var kontakt in Kontaktua.kontaktuakBistaratu())
            {
                int rowIndex = tableLayoutPanel1.RowCount;
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f)); // Altura fija para filas de datos

                // Agregar controles a cada celda
                tableLayoutPanel1.Controls.Add(new Label { Text = kontakt.izena }, 0, rowIndex);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontakt.abizena }, 1, rowIndex);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontakt.telefonoa.ToString() }, 2, rowIndex);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontakt.generoa }, 3, rowIndex);
                tableLayoutPanel1.Controls.Add(new Label { Text = "+"+kontakt.prefijoa.ToString() }, 4, rowIndex);
            }
            // Ajustar la altura del panel contenedor para mostrar exactamente 3 filas + encabezado
            if (panelContenedor != null)
            {
                panelContenedor.Height = (3 * 25) + 30 + 4; // 3 filas de datos + encabezado + bordes
            }
        
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Kontaktua.kontaktuakBistaratu();
        }

        private void btnBilatu_Click(object sender, EventArgs e)
        {
            if (tbTelfBilatu.Text == null)
            {
                MessageBox.Show("Sartu telefono zenbaki bat bilatzeko.");
            }else if (!int.TryParse(tbTelfBilatu.Text, out _))
            {
                MessageBox.Show("Telefono zenbaki bat sartu behar duzu.");
            }else if (Kontaktua.KontaktuaBilatu(int.Parse(tbTelfBilatu.Text)) == null)
            {
                MessageBox.Show("Ez da kontakturik aurkitu zenbaki horrekin.");
            }
            else
            {
                Kontaktua kontBilatu = Kontaktua.KontaktuaBilatu(int.Parse(tbTelfBilatu.Text));// Kontaktu bat itzultzen du.
                taulaGarbitu();
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
                tableLayoutPanel1.Controls.Add(new Label { Text = kontBilatu.izena }, 0, 1);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontBilatu.abizena }, 1, 1);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontBilatu.telefonoa.ToString() }, 2, 1);
                tableLayoutPanel1.Controls.Add(new Label { Text = kontBilatu.generoa }, 3, 1);
                tableLayoutPanel1.Controls.Add(new Label { Text = "+" + kontBilatu.prefijoa.ToString() }, 4, 1);
            }
        }

        private void btnGrafUpdate_Click(object sender, EventArgs e)
        {
            agendaGrafikoa1.Marraztu(Kontaktua.kontaktuak);
        }

        private void taulaGarbitu()
        {
            // Lehen lerroa mantendu (izenburuak)
            tableLayoutPanel1.RowCount = 1;

            // Kontrol guztiak garbitu eta ezabatu
            List<Control> controlesAEliminar = new List<Control>();

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                int fila = tableLayoutPanel1.GetRow(control);
                if (fila >= 1) // Lehen filan edo gorago badago datuak
                {
                    controlesAEliminar.Add(control);
                }
            }

            // datuen kontrolak ezabatu eta errekurtsoak askatu
            foreach (Control control in controlesAEliminar)
            {
                tableLayoutPanel1.Controls.Remove(control);
                control.Dispose(); // Errekurtzoak askatu
            }

            // Filen estiloak garbitu eta lehen lerroa berriro gehitu
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f)); // (Izenburuak)
        }
    }
}
