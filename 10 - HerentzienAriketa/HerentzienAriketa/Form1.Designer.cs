namespace HerentzienAriketa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNan = new Label();
            lbIzena = new Label();
            label1 = new Label();
            label2 = new Label();
            tbNan = new TextBox();
            tbIzena = new TextBox();
            tbAbizena = new TextBox();
            tbEmail = new TextBox();
            gbMotak = new GroupBox();
            cbKontaktua = new CheckBox();
            cbBezeroa = new CheckBox();
            cbLangilea = new CheckBox();
            gbBezeroa = new GroupBox();
            gbLangilea = new GroupBox();
            lbKategoria = new Label();
            combKategora = new ComboBox();
            lbSoldata = new Label();
            lbSS = new Label();
            tbSoldata = new TextBox();
            tbSerguSoziala = new TextBox();
            btnGorde = new Button();
            btnIrten = new Button();
            gbMotak.SuspendLayout();
            gbBezeroa.SuspendLayout();
            gbLangilea.SuspendLayout();
            SuspendLayout();
            // 
            // lbNan
            // 
            lbNan.AutoSize = true;
            lbNan.Location = new Point(83, 50);
            lbNan.Name = "lbNan";
            lbNan.Size = new Size(43, 20);
            lbNan.TabIndex = 0;
            lbNan.Text = "Nan: ";
            // 
            // lbIzena
            // 
            lbIzena.AutoSize = true;
            lbIzena.Location = new Point(83, 85);
            lbIzena.Name = "lbIzena";
            lbIzena.Size = new Size(47, 20);
            lbIzena.TabIndex = 1;
            lbIzena.Text = "Izena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 122);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Abizena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 159);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // tbNan
            // 
            tbNan.Location = new Point(132, 50);
            tbNan.Name = "tbNan";
            tbNan.Size = new Size(125, 27);
            tbNan.TabIndex = 4;
            // 
            // tbIzena
            // 
            tbIzena.Location = new Point(132, 85);
            tbIzena.Name = "tbIzena";
            tbIzena.Size = new Size(125, 27);
            tbIzena.TabIndex = 5;
            // 
            // tbAbizena
            // 
            tbAbizena.Location = new Point(155, 119);
            tbAbizena.Name = "tbAbizena";
            tbAbizena.Size = new Size(125, 27);
            tbAbizena.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(138, 156);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 7;
            // 
            // gbMotak
            // 
            gbMotak.Controls.Add(cbLangilea);
            gbMotak.Controls.Add(cbBezeroa);
            gbMotak.Controls.Add(cbKontaktua);
            gbMotak.Location = new Point(466, 50);
            gbMotak.Name = "gbMotak";
            gbMotak.Size = new Size(250, 125);
            gbMotak.TabIndex = 8;
            gbMotak.TabStop = false;
            gbMotak.Text = "Mota";
            // 
            // cbKontaktua
            // 
            cbKontaktua.AutoSize = true;
            cbKontaktua.Location = new Point(23, 26);
            cbKontaktua.Name = "cbKontaktua";
            cbKontaktua.Size = new Size(98, 24);
            cbKontaktua.TabIndex = 0;
            cbKontaktua.Text = "Kontaktua";
            cbKontaktua.UseVisualStyleBackColor = true;
            // 
            // cbBezeroa
            // 
            cbBezeroa.AutoSize = true;
            cbBezeroa.Location = new Point(23, 56);
            cbBezeroa.Name = "cbBezeroa";
            cbBezeroa.Size = new Size(85, 24);
            cbBezeroa.TabIndex = 1;
            cbBezeroa.Text = "Bezeroa";
            cbBezeroa.UseVisualStyleBackColor = true;
            // 
            // cbLangilea
            // 
            cbLangilea.AutoSize = true;
            cbLangilea.Location = new Point(23, 86);
            cbLangilea.Name = "cbLangilea";
            cbLangilea.Size = new Size(87, 24);
            cbLangilea.TabIndex = 2;
            cbLangilea.Text = "Langilea";
            cbLangilea.UseVisualStyleBackColor = true;
            // 
            // gbBezeroa
            // 
            gbBezeroa.Controls.Add(combKategora);
            gbBezeroa.Controls.Add(lbKategoria);
            gbBezeroa.Location = new Point(83, 214);
            gbBezeroa.Name = "gbBezeroa";
            gbBezeroa.Size = new Size(250, 163);
            gbBezeroa.TabIndex = 9;
            gbBezeroa.TabStop = false;
            gbBezeroa.Text = "Bezeroa";
            // 
            // gbLangilea
            // 
            gbLangilea.Controls.Add(tbSerguSoziala);
            gbLangilea.Controls.Add(tbSoldata);
            gbLangilea.Controls.Add(lbSS);
            gbLangilea.Controls.Add(lbSoldata);
            gbLangilea.Location = new Point(466, 214);
            gbLangilea.Name = "gbLangilea";
            gbLangilea.Size = new Size(250, 163);
            gbLangilea.TabIndex = 10;
            gbLangilea.TabStop = false;
            gbLangilea.Text = "Langilea";
            // 
            // lbKategoria
            // 
            lbKategoria.AutoSize = true;
            lbKategoria.Location = new Point(23, 40);
            lbKategoria.Name = "lbKategoria";
            lbKategoria.Size = new Size(74, 20);
            lbKategoria.TabIndex = 0;
            lbKategoria.Text = "Kategoria";
            // 
            // combKategora
            // 
            combKategora.FormattingEnabled = true;
            combKategora.Location = new Point(23, 73);
            combKategora.Name = "combKategora";
            combKategora.Size = new Size(151, 28);
            combKategora.TabIndex = 1;
            // 
            // lbSoldata
            // 
            lbSoldata.AutoSize = true;
            lbSoldata.Location = new Point(23, 39);
            lbSoldata.Name = "lbSoldata";
            lbSoldata.Size = new Size(67, 20);
            lbSoldata.TabIndex = 0;
            lbSoldata.Text = "Soldata: ";
            // 
            // lbSS
            // 
            lbSS.AutoSize = true;
            lbSS.Location = new Point(16, 88);
            lbSS.Name = "lbSS";
            lbSS.Size = new Size(135, 20);
            lbSS.TabIndex = 1;
            lbSS.Text = "Segurtasun soziala:";
            // 
            // tbSoldata
            // 
            tbSoldata.Location = new Point(106, 32);
            tbSoldata.Name = "tbSoldata";
            tbSoldata.Size = new Size(125, 27);
            tbSoldata.TabIndex = 2;
            // 
            // tbSerguSoziala
            // 
            tbSerguSoziala.Location = new Point(22, 118);
            tbSerguSoziala.Name = "tbSerguSoziala";
            tbSerguSoziala.Size = new Size(209, 27);
            tbSerguSoziala.TabIndex = 3;
            // 
            // btnGorde
            // 
            btnGorde.Location = new Point(239, 400);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(94, 29);
            btnGorde.TabIndex = 11;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = true;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(466, 400);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 12;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrten);
            Controls.Add(btnGorde);
            Controls.Add(gbLangilea);
            Controls.Add(gbBezeroa);
            Controls.Add(gbMotak);
            Controls.Add(tbEmail);
            Controls.Add(tbAbizena);
            Controls.Add(tbIzena);
            Controls.Add(tbNan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbIzena);
            Controls.Add(lbNan);
            Name = "Form1";
            Text = "Form1";
            gbMotak.ResumeLayout(false);
            gbMotak.PerformLayout();
            gbBezeroa.ResumeLayout(false);
            gbBezeroa.PerformLayout();
            gbLangilea.ResumeLayout(false);
            gbLangilea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNan;
        private Label lbIzena;
        private Label label1;
        private Label label2;
        private TextBox tbNan;
        private TextBox tbIzena;
        private TextBox tbAbizena;
        private TextBox tbEmail;
        private GroupBox gbMotak;
        private CheckBox cbLangilea;
        private CheckBox cbBezeroa;
        private CheckBox cbKontaktua;
        private GroupBox gbBezeroa;
        private GroupBox gbLangilea;
        private ComboBox combKategora;
        private Label lbKategoria;
        private TextBox tbSerguSoziala;
        private TextBox tbSoldata;
        private Label lbSS;
        private Label lbSoldata;
        private Button btnGorde;
        private Button btnIrten;
    }
}
