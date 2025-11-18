namespace NutrinfoForm
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInfoShow = new System.Windows.Forms.Button();
            this.nutrinfoDLL1 = new NutrinfoDLL.NutrinfoDLL();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELIKAGAIEN ZERRENDA OSOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(183, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aukeratu elikagaia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnInfoShow
            // 
            this.btnInfoShow.BackColor = System.Drawing.Color.Teal;
            this.btnInfoShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoShow.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInfoShow.Location = new System.Drawing.Point(104, 396);
            this.btnInfoShow.Name = "btnInfoShow";
            this.btnInfoShow.Size = new System.Drawing.Size(326, 81);
            this.btnInfoShow.TabIndex = 3;
            this.btnInfoShow.Text = "Informazioa Bistaratu";
            this.btnInfoShow.UseVisualStyleBackColor = false;
            this.btnInfoShow.Click += new System.EventHandler(this.btnInfoShow_Click);
            // 
            // nutrinfoDLL1
            // 
            this.nutrinfoDLL1.BackColor = System.Drawing.Color.White;
            this.nutrinfoDLL1.Location = new System.Drawing.Point(568, 27);
            this.nutrinfoDLL1.Name = "nutrinfoDLL1";
            this.nutrinfoDLL1.Size = new System.Drawing.Size(553, 472);
            this.nutrinfoDLL1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1170, 524);
            this.Controls.Add(this.nutrinfoDLL1);
            this.Controls.Add(this.btnInfoShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nutrinfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInfoShow;
        private NutrinfoDLL.NutrinfoDLL nutrinfoDLL1;
    }
}

