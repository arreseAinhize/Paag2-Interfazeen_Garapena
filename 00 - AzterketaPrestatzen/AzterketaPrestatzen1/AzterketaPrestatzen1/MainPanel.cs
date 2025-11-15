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
        }

        //If the button is disabled, change it's color to Gray and the text color tu Black
        public void disableButton()
        {
            if (btnRatingSystem.Enabled == false)
            {
                btnRatingSystem.BackColor = Color.Gray;
                btnRatingSystem.ForeColor = Color.Black;
            }
            else if (btnFavoriteReading.Enabled == false)
            {
                btnFavoriteReading.BackColor = Color.Gray;
                btnFavoriteReading.ForeColor = Color.Black;
            }
            else if (btnReadingLog.Enabled == false)
            {
                btnReadingLog.BackColor = Color.Gray;
                btnReadingLog.ForeColor = Color.Black;
            }
            else if (btnReadingPixel.Enabled == false)
            {
                btnReadingPixel.BackColor = Color.Gray;
                btnReadingPixel.ForeColor = Color.Black;
            }
            else if (btnReadingStats.Enabled == false)
            {
                btnReadingStats.BackColor = Color.Gray;
                btnReadingStats.ForeColor = Color.Black;
            }
            else if (btnWishList.Enabled == false)
            {
                btnWishList.BackColor = Color.Gray;
                btnWishList.ForeColor = Color.Black;
            }
        }

        //If the button is enabled, change it's color to Pale Turquoise and the text color tu Teal
        public void enableButton()
        {
            if (btnRatingSystem.Enabled == true)
            {
                btnRatingSystem.BackColor = Color.PaleTurquoise;
                btnRatingSystem.ForeColor = Color.Teal;
            }
            else if (btnFavoriteReading.Enabled == true)
            {
                btnFavoriteReading.BackColor = Color.PaleTurquoise;
                btnFavoriteReading.ForeColor = Color.Teal;
            }
            else if (btnReadingLog.Enabled == true)
            {
                btnReadingLog.BackColor = Color.PaleTurquoise;
                btnReadingLog.ForeColor = Color.Teal;
            }
            else if (btnReadingPixel.Enabled == true)
            {
                btnReadingPixel.BackColor = Color.PaleTurquoise;
                btnReadingPixel.ForeColor = Color.Teal;
            }
            else if (btnReadingStats.Enabled == true)
            {
                btnReadingStats.BackColor = Color.PaleTurquoise;
                btnReadingStats.ForeColor = Color.Teal;
            }
            else if (btnWishList.Enabled == true)
            {
                btnWishList.BackColor = Color.PaleTurquoise;
                btnWishList.ForeColor = Color.Teal;
            }
        }

        //Clear all the controls in the ContentPanel
        public void CleanContentPanel()
        {
            ContentPanel.Controls.Clear();
        }

        //Open the corresponding UserControl in the ContentPanel
        private void OpenPanelContent(UserControl userControlHijo)
        {
            if (ContentPanel.Controls.Count > 0)
                ContentPanel.Controls.RemoveAt(0);

            userControlHijo.Dock = DockStyle.Fill;

            ContentPanel.Controls.Add(userControlHijo);
            ContentPanel.Tag = userControlHijo;
        }

        private void btnRatingSystem_Click(object sender, EventArgs e)
        {
            btnRatingSystem.Enabled = false;
            disableButton();
            btnReadingPixel.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            enableButton();
            OpenPanelContent(new RatingSystem());
        }

        private void btnReadingLog_Click(object sender, EventArgs e)
        {
            btnReadingLog.Enabled = false;
            disableButton();
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            enableButton();
            OpenPanelContent(new ReadingLog());
        }

        private void btnWishList_Click(object sender, EventArgs e)
        {
            btnWishList.Enabled = false;
            disableButton();
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            enableButton();
            OpenPanelContent(new WishList());
        }

        private void btnReadingStats_Click(object sender, EventArgs e)
        {
            btnReadingStats.Enabled = false;
            disableButton();
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnWishList.Enabled = true;
            enableButton();
            OpenPanelContent(new ReadingStats());
        }

        private void btnReadingPixel_Click(object sender, EventArgs e)
        {
            btnReadingPixel.Enabled = false;
            disableButton();
            btnRatingSystem.Enabled = true;
            btnFavoriteReading.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            enableButton();
            OpenPanelContent(new ReadingPixel());
        }

        private void btnFavoriteReading_Click(object sender, EventArgs e)
        {
            btnFavoriteReading.Enabled = false;
            disableButton();
            btnReadingPixel.Enabled = true;
            btnRatingSystem.Enabled = true;
            btnReadingLog.Enabled = true;
            btnReadingStats.Enabled = true;
            btnWishList.Enabled = true;
            enableButton();
            OpenPanelContent(new FavoriteReading());
        }
    }
}
