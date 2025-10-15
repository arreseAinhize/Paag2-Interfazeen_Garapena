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
        List<Kontaktua> kontbilatua = new List<Kontaktua>();
        public Form1()
        {
            InitializeComponent();
            agendaGrafikoa1.Marraztu(Kontaktua.kontaktuak);
            agendaGrafikoaBarra1.MarraztuPrefi(Kontaktua.kontaktuak);
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Kontaktua.kontaktuakBistaratu();
            Console.WriteLine(dataGridView1.DataSource);
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
                kontbilatua.Add(kontBilatu);
                dataGridView1.DataSource = kontbilatua;
            }
        }

        private void btnGrafUpdate_Click(object sender, EventArgs e)
        {
            agendaGrafikoa1.Marraztu(Kontaktua.kontaktuak);
            agendaGrafikoaBarra1.MarraztuPrefi(Kontaktua.kontaktuak);
        }
    }
}
