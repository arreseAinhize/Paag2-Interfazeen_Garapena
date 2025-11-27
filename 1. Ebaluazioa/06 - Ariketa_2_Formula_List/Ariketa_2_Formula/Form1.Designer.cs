namespace Ariketa_2_Formula
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
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            lbZenbakiak = new Label();
            tbZenbakiak = new TextBox();
            SuspendLayout();
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.BackColor = SystemColors.HotTrack;
            btnHurrengoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHurrengoa.ForeColor = SystemColors.Control;
            btnHurrengoa.Location = new Point(130, 296);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(112, 29);
            btnHurrengoa.TabIndex = 0;
            btnHurrengoa.Text = "HURRENGOA";
            btnHurrengoa.UseVisualStyleBackColor = false;
            btnHurrengoa.Click += btnHurrengo_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.BackColor = SystemColors.HotTrack;
            btnGarbitu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGarbitu.ForeColor = SystemColors.Control;
            btnGarbitu.Location = new Point(355, 296);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 1;
            btnGarbitu.Text = "GARBITU";
            btnGarbitu.UseVisualStyleBackColor = false;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.BackColor = SystemColors.HotTrack;
            btnIrten.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrten.ForeColor = SystemColors.Control;
            btnIrten.Location = new Point(580, 296);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 2;
            btnIrten.Text = "IRTEN";
            btnIrten.UseVisualStyleBackColor = false;
            btnIrten.Click += btnIrten_Click;
            // 
            // lbZenbakiak
            // 
            lbZenbakiak.AutoSize = true;
            lbZenbakiak.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbZenbakiak.ForeColor = SystemColors.HotTrack;
            lbZenbakiak.Location = new Point(130, 107);
            lbZenbakiak.Name = "lbZenbakiak";
            lbZenbakiak.Size = new Size(149, 31);
            lbZenbakiak.TabIndex = 3;
            lbZenbakiak.Text = "1. Zenbakia: ";
            // 
            // tbZenbakiak
            // 
            tbZenbakiak.Location = new Point(355, 107);
            tbZenbakiak.Name = "tbZenbakiak";
            tbZenbakiak.Size = new Size(319, 27);
            tbZenbakiak.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbZenbakiak);
            Controls.Add(lbZenbakiak);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
        private Label lbZenbakiak;
        private TextBox tbZenbakiak;
    }
}
