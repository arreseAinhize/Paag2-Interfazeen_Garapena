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
using StatsObjectDll;

namespace PuntuazioBanaketaDll
{
    public partial class PuntuazioBanaketa: UserControl
    {
        public PuntuazioBanaketa()
        {
            InitializeComponent();
        }
        public void Grafikoa_Marraztu(Puntuak puntua)
        {
            // Categorías (⭐1 .. ⭐5)
            string[] legenda = { "⭐1", "⭐2", "⭐3", "⭐4", "⭐5" };

            // Obtener la serie pirámide (Series[0] o por nombre "Series1")
            Series serie = grafikoa1.Series.Count > 0
                ? grafikoa1.Series[0]
                : grafikoa1.Series.Add("Series1");

            // Configuración obligatoria para pirámide
            serie.ChartType = SeriesChartType.Pyramid;
            serie.Points.Clear();
            serie["PyramidLabelStyle"] = "Inside";   // texto dentro
            serie.SmartLabelStyle.Enabled = true;

            // Lista de valores
            List<int> balioak = puntua.AsList();

            // Evitar excepciones por tamaños distintos
            int count = Math.Min(legenda.Length, balioak.Count);

            for (int i = 0; i < count; i++)
            {
                int y = balioak[i];

                // Añadir punto y obtener índice
                int idx = serie.Points.AddY(y);
                DataPoint p = serie.Points[idx];

                // Mostrar valor y porcentaje
                p.Label = "#VAL (#PERCENT{P0})";

                // Nombre de categoría (⭐1..⭐5)
                p.LegendText = legenda[i];

                // Color negro para el texto
                p.LabelForeColor = Color.Black;

                // Opcional: tamaño de fuente
                p.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            grafikoa1.Invalidate();  // Redibujar
        }

    }

}

}

