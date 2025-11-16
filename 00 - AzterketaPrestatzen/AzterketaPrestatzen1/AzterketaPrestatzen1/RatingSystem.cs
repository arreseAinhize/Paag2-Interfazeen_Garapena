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
        }
    }
}
