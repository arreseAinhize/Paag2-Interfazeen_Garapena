namespace AzterketaPrestatzen1
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btnRatingSystem = new System.Windows.Forms.Button();
            this.btnReadingLog = new System.Windows.Forms.Button();
            this.btnReadingStats = new System.Windows.Forms.Button();
            this.btnWishList = new System.Windows.Forms.Button();
            this.btnFavoriteReading = new System.Windows.Forms.Button();
            this.btnReadingPixel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.btnFavoriteReading);
            this.MenuPanel.Controls.Add(this.btnReadingPixel);
            this.MenuPanel.Controls.Add(this.btnReadingStats);
            this.MenuPanel.Controls.Add(this.btnWishList);
            this.MenuPanel.Controls.Add(this.btnReadingLog);
            this.MenuPanel.Controls.Add(this.btnRatingSystem);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(233, 682);
            this.MenuPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(232, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(955, 682);
            this.ContentPanel.TabIndex = 1;
            // 
            // btnRatingSystem
            // 
            this.btnRatingSystem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRatingSystem.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatingSystem.ForeColor = System.Drawing.Color.Teal;
            this.btnRatingSystem.Location = new System.Drawing.Point(12, 12);
            this.btnRatingSystem.Name = "btnRatingSystem";
            this.btnRatingSystem.Size = new System.Drawing.Size(208, 62);
            this.btnRatingSystem.TabIndex = 0;
            this.btnRatingSystem.Text = "Rating System";
            this.btnRatingSystem.UseVisualStyleBackColor = false;
            this.btnRatingSystem.Click += new System.EventHandler(this.btnRatingSystem_Click);
            // 
            // btnReadingLog
            // 
            this.btnReadingLog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReadingLog.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingLog.ForeColor = System.Drawing.Color.Teal;
            this.btnReadingLog.Location = new System.Drawing.Point(12, 89);
            this.btnReadingLog.Name = "btnReadingLog";
            this.btnReadingLog.Size = new System.Drawing.Size(208, 62);
            this.btnReadingLog.TabIndex = 1;
            this.btnReadingLog.Text = "Reading Log";
            this.btnReadingLog.UseVisualStyleBackColor = false;
            this.btnReadingLog.Click += new System.EventHandler(this.btnReadingLog_Click);
            // 
            // btnReadingStats
            // 
            this.btnReadingStats.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReadingStats.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingStats.ForeColor = System.Drawing.Color.Teal;
            this.btnReadingStats.Location = new System.Drawing.Point(12, 244);
            this.btnReadingStats.Name = "btnReadingStats";
            this.btnReadingStats.Size = new System.Drawing.Size(208, 62);
            this.btnReadingStats.TabIndex = 3;
            this.btnReadingStats.Text = "Reading Stats";
            this.btnReadingStats.UseVisualStyleBackColor = false;
            this.btnReadingStats.Click += new System.EventHandler(this.btnReadingStats_Click);
            // 
            // btnWishList
            // 
            this.btnWishList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWishList.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWishList.ForeColor = System.Drawing.Color.Teal;
            this.btnWishList.Location = new System.Drawing.Point(12, 167);
            this.btnWishList.Name = "btnWishList";
            this.btnWishList.Size = new System.Drawing.Size(208, 62);
            this.btnWishList.TabIndex = 2;
            this.btnWishList.Text = "Wish List";
            this.btnWishList.UseVisualStyleBackColor = false;
            this.btnWishList.Click += new System.EventHandler(this.btnWishList_Click);
            // 
            // btnFavoriteReading
            // 
            this.btnFavoriteReading.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFavoriteReading.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoriteReading.ForeColor = System.Drawing.Color.Teal;
            this.btnFavoriteReading.Location = new System.Drawing.Point(12, 398);
            this.btnFavoriteReading.Name = "btnFavoriteReading";
            this.btnFavoriteReading.Size = new System.Drawing.Size(208, 62);
            this.btnFavoriteReading.TabIndex = 5;
            this.btnFavoriteReading.Text = "Favorite Reading";
            this.btnFavoriteReading.UseVisualStyleBackColor = false;
            this.btnFavoriteReading.Click += new System.EventHandler(this.btnFavoriteReading_Click);
            // 
            // btnReadingPixel
            // 
            this.btnReadingPixel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReadingPixel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingPixel.ForeColor = System.Drawing.Color.Teal;
            this.btnReadingPixel.Location = new System.Drawing.Point(12, 321);
            this.btnReadingPixel.Name = "btnReadingPixel";
            this.btnReadingPixel.Size = new System.Drawing.Size(208, 62);
            this.btnReadingPixel.TabIndex = 4;
            this.btnReadingPixel.Text = "Reading Pixel";
            this.btnReadingPixel.UseVisualStyleBackColor = false;
            this.btnReadingPixel.Click += new System.EventHandler(this.btnReadingPixel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AzterketaPrestatzen1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1188, 684);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "Book Journal";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnReadingStats;
        private System.Windows.Forms.Button btnWishList;
        private System.Windows.Forms.Button btnReadingLog;
        private System.Windows.Forms.Button btnRatingSystem;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button btnFavoriteReading;
        private System.Windows.Forms.Button btnReadingPixel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

