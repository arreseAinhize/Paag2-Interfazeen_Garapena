namespace Ariketa_1
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
            tbEsaldia = new TextBox();
            btnEsaldi1 = new Button();
            btnEsaldi2 = new Button();
            btnEsaldi3 = new Button();
            btnEsaldi4 = new Button();
            btnEsaldi5 = new Button();
            btnLotu = new Button();
            btnGarbitu = new Button();
            SuspendLayout();
            // 
            // tbEsaldia
            // 
            tbEsaldia.Location = new Point(193, 48);
            tbEsaldia.Multiline = true;
            tbEsaldia.Name = "tbEsaldia";
            tbEsaldia.Size = new Size(395, 102);
            tbEsaldia.TabIndex = 0;
            // 
            // btnEsaldi1
            // 
            btnEsaldi1.Location = new Point(98, 182);
            btnEsaldi1.Name = "btnEsaldi1";
            btnEsaldi1.Size = new Size(94, 29);
            btnEsaldi1.TabIndex = 1;
            btnEsaldi1.Text = "Esaldia 1";
            btnEsaldi1.UseVisualStyleBackColor = true;
            btnEsaldi1.Click += btnEsaldi1_Click;
            // 
            // btnEsaldi2
            // 
            btnEsaldi2.Location = new Point(348, 182);
            btnEsaldi2.Name = "btnEsaldi2";
            btnEsaldi2.Size = new Size(94, 29);
            btnEsaldi2.TabIndex = 2;
            btnEsaldi2.Text = "Esaldia 2";
            btnEsaldi2.UseVisualStyleBackColor = true;
            btnEsaldi2.Click += btnEsaldi2_Click;
            // 
            // btnEsaldi3
            // 
            btnEsaldi3.Location = new Point(591, 182);
            btnEsaldi3.Name = "btnEsaldi3";
            btnEsaldi3.Size = new Size(94, 29);
            btnEsaldi3.TabIndex = 3;
            btnEsaldi3.Text = "Esaldia 3";
            btnEsaldi3.UseVisualStyleBackColor = true;
            btnEsaldi3.Click += btnEsaldi3_Click;
            // 
            // btnEsaldi4
            // 
            btnEsaldi4.Location = new Point(98, 279);
            btnEsaldi4.Name = "btnEsaldi4";
            btnEsaldi4.Size = new Size(94, 29);
            btnEsaldi4.TabIndex = 4;
            btnEsaldi4.Text = "Esaldia 4";
            btnEsaldi4.UseVisualStyleBackColor = true;
            btnEsaldi4.Click += btnEsaldi4_Click;
            // 
            // btnEsaldi5
            // 
            btnEsaldi5.Location = new Point(348, 279);
            btnEsaldi5.Name = "btnEsaldi5";
            btnEsaldi5.Size = new Size(94, 29);
            btnEsaldi5.TabIndex = 5;
            btnEsaldi5.Text = "Esaldia 5";
            btnEsaldi5.UseVisualStyleBackColor = true;
            btnEsaldi5.Click += btnEsaldi5_Click;
            // 
            // btnLotu
            // 
            btnLotu.Location = new Point(591, 279);
            btnLotu.Name = "btnLotu";
            btnLotu.Size = new Size(94, 29);
            btnLotu.TabIndex = 6;
            btnLotu.Text = "Lotu";
            btnLotu.UseVisualStyleBackColor = true;
            btnLotu.Click += btnLotu_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(98, 373);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(587, 29);
            btnGarbitu.TabIndex = 7;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGarbitu);
            Controls.Add(btnLotu);
            Controls.Add(btnEsaldi5);
            Controls.Add(btnEsaldi4);
            Controls.Add(btnEsaldi3);
            Controls.Add(btnEsaldi2);
            Controls.Add(btnEsaldi1);
            Controls.Add(tbEsaldia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEsaldia;
        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnGarbitu;
    }
}
