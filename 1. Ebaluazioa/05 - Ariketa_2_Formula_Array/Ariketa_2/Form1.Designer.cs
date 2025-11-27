namespace Ariketa_2
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
            lbZenbakiak = new Label();
            tbZenbakiak = new TextBox();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            SuspendLayout();
            // 
            // lbZenbakiak
            // 
            lbZenbakiak.AutoSize = true;
            lbZenbakiak.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbZenbakiak.ForeColor = SystemColors.HotTrack;
            lbZenbakiak.Location = new Point(127, 86);
            lbZenbakiak.Name = "lbZenbakiak";
            lbZenbakiak.Size = new Size(158, 38);
            lbZenbakiak.TabIndex = 0;
            lbZenbakiak.Text = "1. Zenbakia";
            // 
            // tbZenbakiak
            // 
            tbZenbakiak.Location = new Point(313, 97);
            tbZenbakiak.Name = "tbZenbakiak";
            tbZenbakiak.Size = new Size(340, 27);
            tbZenbakiak.TabIndex = 1;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.BackColor = SystemColors.HotTrack;
            btnHurrengoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHurrengoa.ForeColor = SystemColors.Menu;
            btnHurrengoa.Location = new Point(127, 264);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = false;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.BackColor = SystemColors.HotTrack;
            btnGarbitu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGarbitu.ForeColor = SystemColors.Menu;
            btnGarbitu.Location = new Point(346, 264);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 3;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = false;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.BackColor = SystemColors.HotTrack;
            btnIrten.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrten.ForeColor = SystemColors.Menu;
            btnIrten.Location = new Point(559, 264);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = false;
            btnIrten.Click += btnIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbZenbakiak);
            Controls.Add(lbZenbakiak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbZenbakiak;
        private TextBox tbZenbakiak;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}
