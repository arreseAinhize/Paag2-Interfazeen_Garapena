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
            string[] legenda = { "⭐1", "⭐2", "⭐3", "⭐4", "⭐5" };
            var serie = grafikoa1.Series[0];
            serie.Points.Clear();
            serie["PyramidLabelStyle"] = "Inside";
            serie.SmartLabelStyle.Enabled = true;
            var balioak = puntua.AsList();

            for (int i = 0; i < balioak.Count; i++)
            {
                int y = balioak[i];

                // Añadir el valor y obtener el índice del punto
                int index = serie.Points.AddY(y);

                // Acceder al punto por índice
                var punto = serie.Points[index];

                // Etiqueta con valor y porcentaje
                punto.Label = "#VAL (#PERCENT{P0})";

                // Etiqueta lateral con categoría
                punto.LegendText = legenda[i]; 

                // Color del texto
                punto.LabelForeColor = Color.Black;
            }



            grafikoa1.Invalidate(); // Redibujar
        }

    }

}

