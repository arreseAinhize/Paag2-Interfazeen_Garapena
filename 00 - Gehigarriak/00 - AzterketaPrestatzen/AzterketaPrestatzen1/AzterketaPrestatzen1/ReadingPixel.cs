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
    public partial class ReadingPixel : UserControl
    {
        public ReadingPixel()
        {
            InitializeComponent();

        }
        
        private void ReadingPixel_Load(object sender, EventArgs e)
        {
            tableData.ColumnCount = 12;
            tableData.RowCount = 31;

            tableData.Controls.Clear();

            for (int i = 0; i < tableData.RowCount; i++)
            {
                for (int j = 0; j < tableData.ColumnCount; j++)
                {
                    Panel panel = new Panel();

                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Dock = DockStyle.Fill;
                    panel.BackColor = Color.White;
                    panel.Margin = new Padding(1);
                    
                    tableData.Controls.Add(panel, j, i);
                }
            }
        }

        private void Pixel_Click()
        {
            Panel clickedPanel = new Panel();

            String pages = comBoxPags.Text;
            if (pages.Equals("0 - 10"))
            {
                clickedPanel.BackColor = Color.LightPink;
            }
            else if (pages.Equals("11 - 30"))
            {
                clickedPanel.BackColor = Color.Khaki;
            }
            else if (pages.Equals("31 - 50"))
            {
                clickedPanel.BackColor = Color.PaleGreen;
            }
            else if (pages.Equals("51 - 70"))
            {
                clickedPanel.BackColor = Color.LightSkyBlue;
            }
            else if (pages.Equals("71 - 90"))
            {
                clickedPanel.BackColor = Color.MediumPurple;
            }
            else if (pages.Equals("91 - 150"))
            {
                clickedPanel.BackColor = Color.Plum;
            }
            else
            {
                clickedPanel.BackColor = Color.DeepPink;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Pixel_Click();
        }
    }
}
