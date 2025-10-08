namespace Ariketa2_Formula_V1
{
    public partial class Form1 : Form
    {
        private Zenbakia nireZenbakiak = new Zenbakia();
        private int zenbakiKontagailua = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbText.Text, out float balioa))
            {
                nireZenbakiak.EzarriZenbakia(zenbakiKontagailua, balioa);
                zenbakiKontagailua++;

                // Kudeatu testu-etiketen aldaketa eta emaitzaren bistaratzea
                switch (zenbakiKontagailua)
                {
                    case 2:
                        lbText.Text = "2. zenbakia:";
                        tbText.Clear();
                        break;
                    case 3:
                        lbText.Text = "3. zenbakia:";
                        tbText.Clear();
                        break;
                    case 4:
                        lbText.Text = "4. zenbakia:";
                        tbText.Clear();
                        break;
                    case 5:
                        // Lau zenbakiak sartu direnean, eragiketa kalkulatu
                        nireZenbakiak.KalkulatuEragiketa();
                        lbText.Text = "Emaitza:";
                        tbText.Text = nireZenbakiak.EmaitzaString();
                        btnNext.Enabled = false; // "Hurrengoa" botoia desgaitu
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sartutako balioa ez da zenbaki bat. Mesedez, saiatu berriro.");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Zenbakia klaseko datuak garbitu
            nireZenbakiak.Garbitu();

            // Interfazearen elementuak hasieratu
            zenbakiKontagailua = 1;
            tbText.Clear();
            lbText.Text = "1. zenbakia:";
            btnNext.Enabled = true; // "Hurrengoa" botoia gaitu
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
