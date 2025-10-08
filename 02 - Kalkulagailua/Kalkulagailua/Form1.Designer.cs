namespace Kalkulagailua
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
            btnGehitu = new Button();
            btnBidertu = new Button();
            btnKendu = new Button();
            btnZatitu = new Button();
            tbZenbakia1 = new TextBox();
            tbZenbakia2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGehitu
            // 
            btnGehitu.Location = new Point(183, 215);
            btnGehitu.Name = "btnGehitu";
            btnGehitu.Size = new Size(94, 29);
            btnGehitu.TabIndex = 0;
            btnGehitu.Text = "+";
            btnGehitu.UseVisualStyleBackColor = true;
            btnGehitu.Click += btnGehitu_Click;
            // 
            // btnBidertu
            // 
            btnBidertu.Location = new Point(183, 315);
            btnBidertu.Name = "btnBidertu";
            btnBidertu.Size = new Size(94, 29);
            btnBidertu.TabIndex = 1;
            btnBidertu.Text = "×";
            btnBidertu.UseVisualStyleBackColor = true;
            btnBidertu.Click += btnBidertu_Click;
            // 
            // btnKendu
            // 
            btnKendu.Location = new Point(487, 215);
            btnKendu.Name = "btnKendu";
            btnKendu.Size = new Size(94, 29);
            btnKendu.TabIndex = 2;
            btnKendu.Text = "-";
            btnKendu.UseVisualStyleBackColor = true;
            btnKendu.Click += btnKendu_Click;
            // 
            // btnZatitu
            // 
            btnZatitu.Location = new Point(487, 315);
            btnZatitu.Name = "btnZatitu";
            btnZatitu.Size = new Size(94, 29);
            btnZatitu.TabIndex = 3;
            btnZatitu.Text = "÷";
            btnZatitu.UseVisualStyleBackColor = true;
            btnZatitu.Click += btnZatitu_Click;
            // 
            // tbZenbakia1
            // 
            tbZenbakia1.Location = new Point(232, 81);
            tbZenbakia1.Name = "tbZenbakia1";
            tbZenbakia1.Size = new Size(125, 27);
            tbZenbakia1.TabIndex = 4;
            tbZenbakia1.KeyPress += tb1idatzi;
            // 
            // tbZenbakia2
            // 
            tbZenbakia2.Location = new Point(499, 77);
            tbZenbakia2.Name = "tbZenbakia2";
            tbZenbakia2.Size = new Size(125, 27);
            tbZenbakia2.TabIndex = 5;
            tbZenbakia2.KeyPress += tbIdatzi2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 88);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "1. Zenbakia: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 7;
            label2.Text = "2. Zenbakia: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbZenbakia2);
            Controls.Add(tbZenbakia1);
            Controls.Add(btnZatitu);
            Controls.Add(btnKendu);
            Controls.Add(btnBidertu);
            Controls.Add(btnGehitu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGehitu;
        private Button btnBidertu;
        private Button btnKendu;
        private Button btnZatitu;
        private TextBox tbZenbakia1;
        private TextBox tbZenbakia2;
        private Label label1;
        private Label label2;
    }
}
