namespace Ariketa2_Formula_V1
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
            btnNext = new Button();
            btnClean = new Button();
            btnExit = new Button();
            lbText = new Label();
            tbText = new TextBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.HotTrack;
            btnNext.Font = new Font("Sitka Banner Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic);
            btnNext.ForeColor = SystemColors.Control;
            btnNext.Location = new Point(117, 249);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 38);
            btnNext.TabIndex = 0;
            btnNext.Text = "Hurrengoa";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.Highlight;
            btnClean.Font = new Font("Sitka Banner Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic);
            btnClean.ForeColor = SystemColors.Control;
            btnClean.Location = new Point(358, 249);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(102, 38);
            btnClean.TabIndex = 1;
            btnClean.Text = "Garbitu";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.HotTrack;
            btnExit.Font = new Font("Sitka Banner Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(590, 249);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 38);
            btnExit.TabIndex = 2;
            btnExit.Text = "Irten";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Sitka Banner Semibold", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbText.ForeColor = SystemColors.Highlight;
            lbText.Location = new Point(183, 111);
            lbText.Name = "lbText";
            lbText.Size = new Size(97, 28);
            lbText.TabIndex = 3;
            lbText.Text = "1. Zenbakia";
            // 
            // tbText
            // 
            tbText.Location = new Point(309, 116);
            tbText.Name = "tbText";
            tbText.Size = new Size(331, 23);
            tbText.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbText);
            Controls.Add(lbText);
            Controls.Add(btnExit);
            Controls.Add(btnClean);
            Controls.Add(btnNext);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Button btnClean;
        private Button btnExit;
        private Label lbText;
        private TextBox tbText;
    }
}
