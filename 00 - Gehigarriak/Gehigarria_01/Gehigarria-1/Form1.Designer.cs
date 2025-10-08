namespace Gehigarria_1
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
            btnZenbaki1 = new Button();
            btnZenbaki2 = new Button();
            btnZenbaki3 = new Button();
            btnZenbaki4 = new Button();
            btnZenbaki5 = new Button();
            btnEmaitza = new Button();
            btnGarbitu = new Button();
            tbZenbakia = new TextBox();
            SuspendLayout();
            // 
            // btnZenbaki1
            // 
            btnZenbaki1.Location = new Point(113, 213);
            btnZenbaki1.Name = "btnZenbaki1";
            btnZenbaki1.Size = new Size(75, 23);
            btnZenbaki1.TabIndex = 0;
            btnZenbaki1.Text = "Zenbakia 1";
            btnZenbaki1.UseVisualStyleBackColor = true;
            btnZenbaki1.Click += btnZenbaki1_Click;
            // 
            // btnZenbaki2
            // 
            btnZenbaki2.Location = new Point(343, 213);
            btnZenbaki2.Name = "btnZenbaki2";
            btnZenbaki2.Size = new Size(75, 23);
            btnZenbaki2.TabIndex = 1;
            btnZenbaki2.Text = "Zenbakia 2";
            btnZenbaki2.UseVisualStyleBackColor = true;
            btnZenbaki2.Click += btnZenbaki2_Click;
            // 
            // btnZenbaki3
            // 
            btnZenbaki3.Location = new Point(592, 213);
            btnZenbaki3.Name = "btnZenbaki3";
            btnZenbaki3.Size = new Size(75, 23);
            btnZenbaki3.TabIndex = 2;
            btnZenbaki3.Text = "Zenbakia 3";
            btnZenbaki3.UseVisualStyleBackColor = true;
            btnZenbaki3.Click += btnZenbaki3_Click;
            // 
            // btnZenbaki4
            // 
            btnZenbaki4.Location = new Point(113, 307);
            btnZenbaki4.Name = "btnZenbaki4";
            btnZenbaki4.Size = new Size(75, 23);
            btnZenbaki4.TabIndex = 3;
            btnZenbaki4.Text = "Zenbakia 4";
            btnZenbaki4.UseVisualStyleBackColor = true;
            btnZenbaki4.Click += btnZenbaki4_Click;
            // 
            // btnZenbaki5
            // 
            btnZenbaki5.Location = new Point(343, 307);
            btnZenbaki5.Name = "btnZenbaki5";
            btnZenbaki5.Size = new Size(75, 23);
            btnZenbaki5.TabIndex = 4;
            btnZenbaki5.Text = "Zenbakia 5";
            btnZenbaki5.UseVisualStyleBackColor = true;
            btnZenbaki5.Click += btnZenbaki5_Click;
            // 
            // btnEmaitza
            // 
            btnEmaitza.Location = new Point(592, 307);
            btnEmaitza.Name = "btnEmaitza";
            btnEmaitza.Size = new Size(75, 23);
            btnEmaitza.TabIndex = 5;
            btnEmaitza.Text = "Emaitza";
            btnEmaitza.UseVisualStyleBackColor = true;
            btnEmaitza.Click += btnEmaitza_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(343, 372);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(75, 23);
            btnGarbitu.TabIndex = 6;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // tbZenbakia
            // 
            tbZenbakia.Location = new Point(206, 50);
            tbZenbakia.Multiline = true;
            tbZenbakia.Name = "tbZenbakia";
            tbZenbakia.Size = new Size(374, 98);
            tbZenbakia.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbZenbakia);
            Controls.Add(btnGarbitu);
            Controls.Add(btnEmaitza);
            Controls.Add(btnZenbaki5);
            Controls.Add(btnZenbaki4);
            Controls.Add(btnZenbaki3);
            Controls.Add(btnZenbaki2);
            Controls.Add(btnZenbaki1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZenbaki1;
        private Button btnZenbaki2;
        private Button btnZenbaki3;
        private Button btnZenbaki4;
        private Button btnZenbaki5;
        private Button btnEmaitza;
        private Button btnGarbitu;
        private TextBox tbZenbakia;
    }
}
