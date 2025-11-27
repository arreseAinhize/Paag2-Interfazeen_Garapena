namespace Ariketa_2_Formula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 0;
        List<Zenbakia> zenbakiak = new List<Zenbakia>(4);
        private void btnHurrengo_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    zenbakiak.Add(new Zenbakia(float.Parse(tbZenbakiak.Text)));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "2. Zenbakia: ";
                    break;

                case 1:
                    zenbakiak.Add(new Zenbakia(float.Parse(tbZenbakiak.Text)));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "3. Zenbakia: ";
                    break;

                case 2:
                    zenbakiak.Add(new Zenbakia(float.Parse(tbZenbakiak.Text)));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "4. Zenbakia: ";
                    break;

                case 3:
                    zenbakiak.Add(new Zenbakia(float.Parse(tbZenbakiak.Text)));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "Emaitza: ";
                    zenbakiak[0].SetEmaitza(zenbakiak);
                    tbZenbakiak.Text = zenbakiak[0].GetEmaitzaString(zenbakiak);
                    btnHurrengoa.Enabled = false;
                    count = 0;
                    break;

                default:
                    MessageBox.Show("4 zenbaki sartu dira jada");
                    count = 0;
                    break;
            }
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            tbZenbakiak.Clear();
            zenbakiak.Clear();
            btnHurrengoa.Enabled = true;
            lbZenbakiak.Text = "1. Zenbakia: ";
            count = 0;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
