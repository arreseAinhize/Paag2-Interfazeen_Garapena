/*
 Hasieran 1. irudia ikusten da. Zenbaki bat sartu ondoren “Hurrengoa” botoia sakatzen dugu.
“2.zenbakia” agertzen da etiketan eta beste zenbaki bat itxaroten geratzen
da. Hiru eta laugarren zenbakiekin berdin egiten dugu. Azken zenbakia
sartu eta “Hurrengoa” sakatuz gero 3. irudia agertuko da.
Formula: (a+2b+3c+4d)/4
**egin den eragiketa agertzen da** “Garbitu” sakatuta hasierako modura itzultzen gara.
-Klase bat sortu zenbakiak gordetzeko eta eragiketa egiteko
-Switch case …. egitura erabili
 */

namespace Ariketa_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zenbakia[] zenbakiak = new Zenbakia[4];
        private int count = 0;

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    zenbakiak[0] = new Zenbakia(float.Parse(tbZenbakiak.Text));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "2. Zenabkai: ";
                    break;
                case 1:
                    zenbakiak[1] = new Zenbakia(float.Parse(tbZenbakiak.Text));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "3. Zenbakia: ";
                    break;

                case 2:
                    zenbakiak[2] = new Zenbakia(float.Parse(tbZenbakiak.Text));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "4. Zenbakia: ";
                    break;
                case 3:
                    zenbakiak[3] = new Zenbakia(float.Parse(tbZenbakiak.Text));
                    tbZenbakiak.Clear();
                    count++;
                    lbZenbakiak.Text = "Emaitza: ";
                    zenbakiak[0].SetEmaitza(zenbakiak);
                    tbZenbakiak.Text = (zenbakiak[0].GetEmaitzaString(zenbakiak));
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
            zenbakiak = new Zenbakia[4];
            btnHurrengoa.Enabled = true;
            lbZenbakiak.Text = "1. Zenbakia: ";
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
