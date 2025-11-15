namespace GastuDiruaDll
{
    partial class GastuDirua
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
            this.grafikoa1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafikoa1)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikoa1
            // 
            this.grafikoa1.BackColor = System.Drawing.Color.Transparent;
            this.grafikoa1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grafikoa1.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.grafikoa1.Legends.Add(legend1);
            this.grafikoa1.Location = new System.Drawing.Point(3, 3);
            this.grafikoa1.Name = "grafikoa1";
            this.grafikoa1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafikoa1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(201)))), ((int)(((byte)(209))))),
        System.Drawing.Color.Teal};
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.grafikoa1.Series.Add(series1);
            this.grafikoa1.Size = new System.Drawing.Size(270, 220);
            this.grafikoa1.TabIndex = 0;
            this.grafikoa1.Text = "chart1";
            // 
            // GastuDirua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grafikoa1);
            this.Name = "GastuDirua";
            this.Size = new System.Drawing.Size(270, 220);
            ((System.ComponentModel.ISupportInitialize)(this.grafikoa1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafikoa1;
    }
}
