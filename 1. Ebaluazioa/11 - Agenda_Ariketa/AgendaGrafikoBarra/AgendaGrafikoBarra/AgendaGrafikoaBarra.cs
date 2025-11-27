using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda;
using System.Windows.Forms.DataVisualization.Charting;

namespace AgendaGrafikoBarra
{
    public partial class AgendaGrafikoaBarra: UserControl
    {
        public AgendaGrafikoaBarra()
        {
            InitializeComponent();
        }
        public void MarraztuPrefi(List<Kontaktua> kontaktuak)
        {
            // Limpiar puntos previos
            grafikoa.Series[0].Points.Clear();

            grafikoa.Series[0].IsValueShownAsLabel = true;
            grafikoa.Series[0].Label = "#VALX: #PERCENT{P1}";
            grafikoa.Series[0].ChartType = SeriesChartType.Column; // o Pie/Doughnut según el caso

            grafikoa.Legends[0].Title = "PREFIJOAK";
            grafikoa.Legends[0].TitleFont = new Font("Arial", 10, FontStyle.Bold);
            grafikoa.Legends[0].TitleAlignment = StringAlignment.Center;

            var taldekatuta = kontaktuak
                .GroupBy(k => k.prefijoa)
                .Select(g => new { Prefijoa = g.Key, Kopurua = g.Count() })
                .ToList();

            foreach (var item in taldekatuta)
            {
                grafikoa.Series[0].Points.AddXY(item.Prefijoa, item.Kopurua);
            }
        }

    }
}
