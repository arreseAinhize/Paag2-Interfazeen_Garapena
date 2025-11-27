namespace AgendaGrafikoa
{
    partial class AgendaGrafikoa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafikoa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafikoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikoa
            // 
            chartArea1.Name = "ChartArea1";
            this.grafikoa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafikoa.Legends.Add(legend1);
            this.grafikoa.Location = new System.Drawing.Point(3, 3);
            this.grafikoa.Name = "grafikoa";
            this.grafikoa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Label = "#PERCENT{P1}";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafikoa.Series.Add(series1);
            this.grafikoa.Size = new System.Drawing.Size(343, 343);
            this.grafikoa.TabIndex = 0;
            this.grafikoa.Text = "chart1";
            // 
            // AgendaGrafikoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grafikoa);
            this.Name = "AgendaGrafikoa";
            this.Size = new System.Drawing.Size(349, 351);
            ((System.ComponentModel.ISupportInitialize)(this.grafikoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart grafikoa;
    }
}
