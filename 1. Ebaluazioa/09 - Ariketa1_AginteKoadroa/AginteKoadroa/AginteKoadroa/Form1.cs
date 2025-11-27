using AginteKoadroa_PG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                //1. GRAFIKOA:
                // Bezero kopurua saltzaile bakoitzeko taldekatuta
                var bezeroaData = db.Bezeroa
                .Include("Saltzailea")
                .GroupBy(b => b.Saltzailea.Izena)
                .ToDictionary(g => g.Key, g => g.Count());
                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                        chart1.DataSource = bezeroaData;
                        chart1.Series[0].YValueMembers = "Value";
                        chart1.Series[0].XValueMember = "Key";
                        chart1.DataBind();
                    }
                }

                // 2. GRAFIKOA:
                // Salmenta totala bezero bakoitzeko ID-ren arabera taldekatuta
                var salmentaData = db.Salmenta
                    .Include("Bezeroa")
                    .GroupBy(b => b.Bezeroa.Id)
                    .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));

                if (salmentaData != null && salmentaData.Count > 0)
                {
                    // Serie1 hartu (diseinatzailean sortua, iadanik existitzen da)
                    var serie = chart2.Series["Serie1"];

                    // Serie garbitu (aurreko puntuak kendu)
                    serie.Points.Clear();

                    // Serie berria sortu (Doughnut mota)
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                    // Datuak ezarri
                    chart2.DataSource = salmentaData;
                    serie.XValueMember = "Key";    // Bezeroaren ID
                    serie.YValueMembers = "Value"; // Salmenta guztira

                    // Seriearen propietateak ezarri
                    serie.Label = "#VALY"; // Kantitate totala donuts barruan --> "#PERCENT{P0}" portzentaia agertzeko
                    serie.LegendText = "Bezeroa: #VALX"; // Legendan bezeroaren id-a agertzeko

                    // Tituloa ezarri
                    if (chart2.Titles.Count == 0)
                        chart2.Titles.Add("SALMENTA GEHIENGO BEZEROAK");
                    else
                        chart2.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                    
                    // Chart-a eguneratu
                    chart2.DataBind();
                }

                // 3. GRAFIKOA:
                // Salmenta totala bezero bakoitzeko izena-ren arabera taldekatuta
                var salmentaDatak = db.Salmenta
                    .Include("Bezeroa")
                    .GroupBy(b => b.Bezeroa.Id)
                    .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));

                if (salmentaDatak != null && salmentaDatak.Count > 0)
                {
                    grafikoa1.chart1.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                    grafikoa1.chart1.DataSource = salmentaData;
                    grafikoa1.chart1.Series[0].YValueMembers = "Value";
                    grafikoa1.chart1.Series[0].XValueMember = "Key";
                    grafikoa1.chart1.Series[0].Label = "#PERCENT{P0}";
                    grafikoa1.chart1.Series[0].LegendText = "#VALX";
                    grafikoa1.chart1.DataBind();
                }

                // Label-en datuak ezarri:
                // Bezero eta saltzaile totala lortu
                int totalBezeroak = db.Bezeroa.Count();
                int totalSaltzaileak = db.Saltzailea.Count();

                // Label-en testua ezarri
                lbBezGuz.Text = totalBezeroak.ToString();
                lbSalGuz.Text = totalSaltzaileak.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
