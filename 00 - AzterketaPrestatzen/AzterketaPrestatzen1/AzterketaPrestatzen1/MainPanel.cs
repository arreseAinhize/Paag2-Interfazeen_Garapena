using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzterketaPrestatzen1
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            logoTxikia.Enabled = false;
        }

        // Botoien kolorea aldatu egoeraren arabera (Enable/Disable)
        public void UpdateButtonColors()
        {
            List<Button> botoia = new List<Button>()
            {
                btnRatingSystem,
                btnFavoriteReading,
                btnReadingLog,
                btnReadingPixel,
                btnReadingStats,
                btnWishList
            };

            foreach (Button btn in botoia)
            {
                if (!btn.Enabled)
                {
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.Teal;
                }
            }
        }


        // Paneleko control gustiak ezabatu
        public void CleanContentPanel()
        {
            ContentPanel.Controls.Clear();
        }

        // Tokatzen den UserController-a zabaldu panel printzipalean
        private void OpenPanelContent(UserControl userControl)
        {
            logoTxikia.Enabled = true;

            if (ContentPanel.Controls.Count > 0)
                ContentPanel.Controls.RemoveAt(0);

            userControl.Dock = DockStyle.Fill;

            ContentPanel.Controls.Add(userControl);
            ContentPanel.Tag = userControl;
        }

        private void btnRatingSystem_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnRatingSystem.Enabled = false;
            btnReadingPixel.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new RatingSystem());
        }

        private void btnReadingLog_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnReadingLog.Enabled = false;
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new ReadingLog());
        }

        private void btnWishList_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnWishList.Enabled = false;
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new WishList());
        }

        private void btnReadingStats_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnReadingStats.Enabled = false;
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnWishList.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new ReadingStats());
        }

        private void btnReadingPixel_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnReadingPixel.Enabled = false;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new ReadingPixel());
        }

        private void btnFavoriteReading_Click(object sender, EventArgs e)
        {
            CleanContentPanel();
            btnFavoriteReading.Enabled = false;
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            UpdateButtonColors();
            OpenPanelContent(new FavoriteReading());
        }
    }
}
