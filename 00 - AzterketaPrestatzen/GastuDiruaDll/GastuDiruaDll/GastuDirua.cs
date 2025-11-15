using StatsObjectDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GastuDiruaDll
{
    public partial class GastuDirua: UserControl
    {
        public GastuDirua()
        {
            InitializeComponent();
        }

        public void Grafikoa_Marraztu(List<Gastuak> lista)
        {
            // Limpiar series anteriores
            grafikoa1.Series.Clear();

            // Crear la serie con tu estilo exacto
            Series serie = new Series("Gastuak");
            serie.ChartType = SeriesChartType.Line;
            serie.BorderWidth = 3;
            serie.Color = Color.FromArgb(95, 201, 209);
            serie.ChartArea = "ChartArea1";
            serie.Legend = "Legend1";

            grafikoa1.Series.Add(serie);

            // Añadir puntos
            foreach (var g in lista)
            {
                grafikoa1.Series["Gastuak"].Points.AddXY(
                    g.GetMonthLabel(),   // "Ene 2025", "Feb 2025"...
                    g.Prezioa            // valor decimal del gasto
                );
            }

            // Configurar eje X para mostrar todos los meses
            grafikoa1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            // Hacer la línea suave y bonita (opcional)
            grafikoa1.Series["Gastuak"].BorderWidth = 4;
            grafikoa1.Series["Gastuak"].BorderDashStyle = ChartDashStyle.Solid;

            // Redibujar
            grafikoa1.Invalidate();
        }
    }
}
