using Microsoft.SqlServer.Server;
using NutrinfoForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NutrinfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = NutrinfoDbContext.GetElikagaiak(); // from-a kartatu eta segidan datuak bistaratu taulan.
        }

        private void btnInfoShow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) {
                MessageBox.Show("Mesedez, klikatu ezkerreko gezian produktu guztia aukeratzeko.");
            }
            else
            {
                DataGridViewRow lerroa = dataGridView1.SelectedRows[0];
                int aukeratuID = (int)lerroa.Cells["id"].Value; // Lerroko ide eskuratu

                Console.WriteLine("Aukeratutako elikagaiaren id-a: " + aukeratuID); //id-a ondo eskuratzen den egiaztatu

                using (var db = new NutrinfoDbContext())
                {
                    var InformazioaData = db.informazioa
                        .Include("osagaia") // Beste modu bat --> .Include(i => i.osagaia)
                        // FUNTZIONATZEKO FALTA ZEN ATALAREN HASIERA
                        .Where(i => i.ElikagaiaId == aukeratuID) // <-- ID filtroa sartze falta zan
                         // FUNTZIONATZEKO FALTA ZEN ATALAREN BUKAERA
                        .GroupBy(b => b.osagaia.Izena)
                        .ToDictionary(g => g.Key, g => g.Sum(i => i.Kantitatea));//<-- count beharrean sum da.

                    if (InformazioaData != null && InformazioaData.Count > 0)
                    {
                        var serie = nutrinfoDLL1.chart1.Series[0];

                        serie.Points.Clear();

                        // FUNTZIONATZEKO FALTA ZEN ATALAREN HASIERA
                        // Datu iturria sortu Osagaia izenak eta kantitateak erabiliz
                        var dataSource = InformazioaData
                            .Select(kvp => new { Key = kvp.Key, Value = kvp.Value })
                            .ToList();
                        // FUNTZIONATZEKO FALTA ZEN ATALAREN BUKAERA
                        nutrinfoDLL1.chart1.DataSource = dataSource; // InformazioaData erabili beharrean, dataSource "berria" erabili


                        serie.XValueMember = "Key";
                        serie.YValueMembers = "Value";

                        // porcentaje
                        serie.Label = "#PERCENT{P0}";
                        serie.LegendText = "#AXISLABEL"; // legenda osagaien izena erakusteko --> izena

                        nutrinfoDLL1.chart1.DataBind();
                    }
                }
            }

        }
    }
}
