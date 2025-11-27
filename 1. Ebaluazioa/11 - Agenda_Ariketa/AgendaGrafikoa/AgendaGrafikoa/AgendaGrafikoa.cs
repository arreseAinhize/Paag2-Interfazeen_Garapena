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
    public partial class AgendaGrafikoa : UserControl
    {
        public AgendaGrafikoa()
        {
            InitializeComponent();
        }

        public void Marraztu(List<Kontaktua> kontaktuak)
        {
            // Limpiar los puntos existentes antes de volver a dibujar
            grafikoa.Series[0].Points.Clear();

            grafikoa.Series[0].LegendText = "#VALX";
            grafikoa.Series[0].Label = "#PERCENT{P1}";

            // Configurar el título del Legend
            grafikoa.Legends[0].Title = "GENEROAK";
            grafikoa.Legends[0].TitleFont = new Font("Arial", 10, FontStyle.Bold);
            grafikoa.Legends[0].TitleAlignment = StringAlignment.Center;

            // Agrupar contactos por género
            var taldekatuta = kontaktuak
                .GroupBy(k => k.generoa)
                .Select(g => new { Generoa = g.Key, Kopurua = g.Count() })
                .ToList();

            foreach (var item in taldekatuta)
            {
                grafikoa.Series[0].Points.AddXY(item.Generoa, item.Kopurua);
            }
        }
    }
}
