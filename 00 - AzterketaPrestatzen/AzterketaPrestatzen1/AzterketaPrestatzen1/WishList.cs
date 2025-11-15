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
    public partial class WishList : UserControl
    {
        public WishList()
        {
            InitializeComponent();
        }
        void changeButtonColor()
        {
            var main = (MainPanel)Application.OpenForms["MainPanel"];
            main.enableButton();
            main.disableButton();
        }
    }
}
