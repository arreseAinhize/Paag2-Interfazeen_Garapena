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
using Agenda;

namespace AgendaGrafikoa
{
    public partial class AgendaGrafikoa: UserControl
    {
        public AgendaGrafikoa()
        {
            InitializeComponent();
        }

        public void Marraztu(List<Kontaktua> kontaktuak)
        {
            grafikoa.Series.Clear();

            var serie = new Series("GeneroarenArabera");
            serie.ChartType = SeriesChartType.Doughnut; 
            serie.LegendText = "#VALX";
            serie.Label = "#PERCENT{P1}";

            // Configurar el título del Legend
            grafikoa.Legends[0].Title = "GENEROAK"; 
            grafikoa.Legends[0].TitleFont = new Font("Arial", 10, FontStyle.Bold);
            grafikoa.Legends[0].TitleAlignment = StringAlignment.Center;

            // Agrupar contactos por género
            var taldekatuta = kontaktuak
                .GroupBy(k => k.generoa)
                .Select(g => new { Generoa = g.Key, Kopurua = g.Count() });

            foreach (var item in taldekatuta)
            {
                serie.Points.AddXY(item.Generoa, item.Kopurua);
            }
            grafikoa.Series.Add(serie);
        }
    }
}
