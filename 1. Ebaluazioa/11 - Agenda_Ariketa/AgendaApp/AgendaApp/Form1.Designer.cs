namespace AgendaApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGehitu = new System.Windows.Forms.Button();
            this.btnIkusi = new System.Windows.Forms.Button();
            this.btnBilatu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIzena = new System.Windows.Forms.TextBox();
            this.tbAbizena = new System.Windows.Forms.TextBox();
            this.tbTelefonoa = new System.Windows.Forms.TextBox();
            this.tbPrefijoa = new System.Windows.Forms.TextBox();
            this.cbGeneroa = new System.Windows.Forms.ComboBox();
            this.btnGrafUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelfBilatu = new System.Windows.Forms.TextBox();
            this.agendaGrafikoa1 = new AgendaGrafikoa.AgendaGrafikoa();
            this.izenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abizenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefijoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaGrafikoaBarra1 = new AgendaGrafikoBarra.AgendaGrafikoaBarra();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGehitu
            // 
            this.btnGehitu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGehitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGehitu.Location = new System.Drawing.Point(475, 30);
            this.btnGehitu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGehitu.Name = "btnGehitu";
            this.btnGehitu.Size = new System.Drawing.Size(151, 58);
            this.btnGehitu.TabIndex = 0;
            this.btnGehitu.Text = "Gehitu";
            this.btnGehitu.UseVisualStyleBackColor = false;
            this.btnGehitu.Click += new System.EventHandler(this.btnGehitu_Click);
            // 
            // btnIkusi
            // 
            this.btnIkusi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIkusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIkusi.Location = new System.Drawing.Point(475, 109);
            this.btnIkusi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIkusi.Name = "btnIkusi";
            this.btnIkusi.Size = new System.Drawing.Size(151, 58);
            this.btnIkusi.TabIndex = 1;
            this.btnIkusi.Text = "Ikusi";
            this.btnIkusi.UseVisualStyleBackColor = false;
            this.btnIkusi.Click += new System.EventHandler(this.btnIkusi_Click);
            // 
            // btnBilatu
            // 
            this.btnBilatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBilatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilatu.Location = new System.Drawing.Point(474, 276);
            this.btnBilatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBilatu.Name = "btnBilatu";
            this.btnBilatu.Size = new System.Drawing.Size(151, 58);
            this.btnBilatu.TabIndex = 2;
            this.btnBilatu.Text = "Bilatu";
            this.btnBilatu.UseVisualStyleBackColor = false;
            this.btnBilatu.Click += new System.EventHandler(this.btnBilatu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abizena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefonoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generoa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prefijoa:";
            // 
            // tbIzena
            // 
            this.tbIzena.BackColor = System.Drawing.SystemColors.Menu;
            this.tbIzena.Location = new System.Drawing.Point(108, 32);
            this.tbIzena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIzena.Name = "tbIzena";
            this.tbIzena.Size = new System.Drawing.Size(311, 22);
            this.tbIzena.TabIndex = 8;
            // 
            // tbAbizena
            // 
            this.tbAbizena.BackColor = System.Drawing.SystemColors.Menu;
            this.tbAbizena.Location = new System.Drawing.Point(133, 84);
            this.tbAbizena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAbizena.Name = "tbAbizena";
            this.tbAbizena.Size = new System.Drawing.Size(284, 22);
            this.tbAbizena.TabIndex = 9;
            // 
            // tbTelefonoa
            // 
            this.tbTelefonoa.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTelefonoa.Location = new System.Drawing.Point(152, 144);
            this.tbTelefonoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefonoa.Name = "tbTelefonoa";
            this.tbTelefonoa.Size = new System.Drawing.Size(265, 22);
            this.tbTelefonoa.TabIndex = 10;
            // 
            // tbPrefijoa
            // 
            this.tbPrefijoa.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPrefijoa.Location = new System.Drawing.Point(128, 257);
            this.tbPrefijoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrefijoa.Name = "tbPrefijoa";
            this.tbPrefijoa.Size = new System.Drawing.Size(291, 22);
            this.tbPrefijoa.TabIndex = 11;
            // 
            // cbGeneroa
            // 
            this.cbGeneroa.BackColor = System.Drawing.SystemColors.Menu;
            this.cbGeneroa.FormattingEnabled = true;
            this.cbGeneroa.Items.AddRange(new object[] {
            "Neska",
            "Mutila",
            "Non-binary",
            "Beste bat"});
            this.cbGeneroa.Location = new System.Drawing.Point(139, 206);
            this.cbGeneroa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGeneroa.Name = "cbGeneroa";
            this.cbGeneroa.Size = new System.Drawing.Size(280, 24);
            this.cbGeneroa.TabIndex = 12;
            this.cbGeneroa.Text = "Beste bat";
            // 
            // btnGrafUpdate
            // 
            this.btnGrafUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGrafUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafUpdate.Location = new System.Drawing.Point(474, 194);
            this.btnGrafUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrafUpdate.Name = "btnGrafUpdate";
            this.btnGrafUpdate.Size = new System.Drawing.Size(151, 58);
            this.btnGrafUpdate.TabIndex = 13;
            this.btnGrafUpdate.Text = "Grafikoa Eguneratu";
            this.btnGrafUpdate.UseVisualStyleBackColor = false;
            this.btnGrafUpdate.Click += new System.EventHandler(this.btnGrafUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.izenaDataGridViewTextBoxColumn,
            this.abizenaDataGridViewTextBoxColumn,
            this.telefonoaDataGridViewTextBoxColumn,
            this.generoaDataGridViewTextBoxColumn,
            this.prefijoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontaktuaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telefonoz bilatu:";
            // 
            // tbTelfBilatu
            // 
            this.tbTelfBilatu.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTelfBilatu.Location = new System.Drawing.Point(210, 312);
            this.tbTelfBilatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelfBilatu.Name = "tbTelfBilatu";
            this.tbTelfBilatu.Size = new System.Drawing.Size(209, 22);
            this.tbTelfBilatu.TabIndex = 19;
            // 
            // agendaGrafikoa1
            // 
            this.agendaGrafikoa1.Location = new System.Drawing.Point(633, 32);
            this.agendaGrafikoa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agendaGrafikoa1.Name = "agendaGrafikoa1";
            this.agendaGrafikoa1.Size = new System.Drawing.Size(394, 253);
            this.agendaGrafikoa1.TabIndex = 15;
            // 
            // izenaDataGridViewTextBoxColumn
            // 
            this.izenaDataGridViewTextBoxColumn.DataPropertyName = "izena";
            this.izenaDataGridViewTextBoxColumn.HeaderText = "izena";
            this.izenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izenaDataGridViewTextBoxColumn.Name = "izenaDataGridViewTextBoxColumn";
            this.izenaDataGridViewTextBoxColumn.Width = 85;
            // 
            // abizenaDataGridViewTextBoxColumn
            // 
            this.abizenaDataGridViewTextBoxColumn.DataPropertyName = "abizena";
            this.abizenaDataGridViewTextBoxColumn.HeaderText = "abizena";
            this.abizenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.abizenaDataGridViewTextBoxColumn.Name = "abizenaDataGridViewTextBoxColumn";
            this.abizenaDataGridViewTextBoxColumn.Width = 85;
            // 
            // telefonoaDataGridViewTextBoxColumn
            // 
            this.telefonoaDataGridViewTextBoxColumn.DataPropertyName = "telefonoa";
            this.telefonoaDataGridViewTextBoxColumn.HeaderText = "telefonoa";
            this.telefonoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoaDataGridViewTextBoxColumn.Name = "telefonoaDataGridViewTextBoxColumn";
            this.telefonoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoaDataGridViewTextBoxColumn
            // 
            this.generoaDataGridViewTextBoxColumn.DataPropertyName = "generoa";
            this.generoaDataGridViewTextBoxColumn.HeaderText = "generoa";
            this.generoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoaDataGridViewTextBoxColumn.Name = "generoaDataGridViewTextBoxColumn";
            this.generoaDataGridViewTextBoxColumn.Width = 85;
            // 
            // prefijoaDataGridViewTextBoxColumn
            // 
            this.prefijoaDataGridViewTextBoxColumn.DataPropertyName = "prefijoa";
            this.prefijoaDataGridViewTextBoxColumn.HeaderText = "prefijoa";
            this.prefijoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prefijoaDataGridViewTextBoxColumn.Name = "prefijoaDataGridViewTextBoxColumn";
            this.prefijoaDataGridViewTextBoxColumn.Width = 75;
            // 
            // kontaktuaBindingSource
            // 
            this.kontaktuaBindingSource.DataSource = typeof(Agenda.Kontaktua);
            // 
            // agendaGrafikoaBarra1
            // 
            this.agendaGrafikoaBarra1.Location = new System.Drawing.Point(677, 354);
            this.agendaGrafikoaBarra1.Name = "agendaGrafikoaBarra1";
            this.agendaGrafikoaBarra1.Size = new System.Drawing.Size(335, 304);
            this.agendaGrafikoaBarra1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 670);
            this.Controls.Add(this.agendaGrafikoaBarra1);
            this.Controls.Add(this.tbTelfBilatu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.agendaGrafikoa1);
            this.Controls.Add(this.btnGrafUpdate);
            this.Controls.Add(this.cbGeneroa);
            this.Controls.Add(this.tbPrefijoa);
            this.Controls.Add(this.tbTelefonoa);
            this.Controls.Add(this.tbAbizena);
            this.Controls.Add(this.tbIzena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBilatu);
            this.Controls.Add(this.btnIkusi);
            this.Controls.Add(this.btnGehitu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktuaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGehitu;
        private System.Windows.Forms.Button btnIkusi;
        private System.Windows.Forms.Button btnBilatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIzena;
        private System.Windows.Forms.TextBox tbAbizena;
        private System.Windows.Forms.TextBox tbTelefonoa;
        private System.Windows.Forms.TextBox tbPrefijoa;
        private System.Windows.Forms.ComboBox cbGeneroa;
        private System.Windows.Forms.Button btnGrafUpdate;
        private AgendaGrafikoa.AgendaGrafikoa agendaGrafikoa1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kontaktuaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn izenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abizenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefijoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelfBilatu;
        private AgendaGrafikoBarra.AgendaGrafikoaBarra agendaGrafikoaBarra1;
    }
}

