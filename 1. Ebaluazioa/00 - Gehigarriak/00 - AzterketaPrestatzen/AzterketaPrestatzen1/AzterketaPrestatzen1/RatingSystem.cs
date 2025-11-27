using AzterketaPrestatzen1.Models;
using StatsObjectDll;
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
    public partial class RatingSystem : UserControl
    {
        public RatingSystem()
        {
            InitializeComponent();
            RatingSystemBete();
            
        }
        
        private void RatingSystemBete()
        {
            var ratingValues = Models.BookJournalDbContext.GetRatingSystem();
            tbStar5.Text = ratingValues.star1.ToString();
            tbStar4.Text = ratingValues.star2.ToString();
            tbStar3.Text = ratingValues.star3.ToString();
            tbStar2.Text = ratingValues.star4.ToString();
            tbStar1.Text = ratingValues.star5.ToString();
            tbStar1.ReadOnly = true;
            tbStar2.ReadOnly = true;
            tbStar3.ReadOnly = true;
            tbStar4.ReadOnly = true;
            tbStar5.ReadOnly = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbStar1.ReadOnly = false;
            tbStar2.ReadOnly = false;
            tbStar3.ReadOnly = false;
            tbStar4.ReadOnly = false;
            tbStar5.ReadOnly = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RatingSystemValues BalioBerriak = new RatingSystemValues
            {
                star1 = tbStar5.Text,
                star2 = tbStar4.Text,
                star3 = tbStar3.Text,
                star4 = tbStar2.Text,
                star5 = tbStar1.Text
            };
            BookJournalDbContext.UpdateRatingSystem(BalioBerriak);
            RatingSystemBete();
        }
    }
}
