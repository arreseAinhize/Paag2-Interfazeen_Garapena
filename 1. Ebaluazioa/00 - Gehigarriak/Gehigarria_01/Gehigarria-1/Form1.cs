/*
 Ariketa 1: Sortu zenbakien aplikazioa.

 - Hasieran “Zenbakia1” botoia bakarrik aktibatuta dago.
 - Testu kutxan lehenengo zenbakia idatzi eta Numero1 botoia sakatzen dugu → hau desaktibatuta geratzen da eta Zenbakia2 aktibatuta.
 - Gauza bera gertatzen da Zenbakia2–Zenbakia5 botoiekin.
 - Bosgarren botoia sakatu ondoren “Kalkulatu” eta “Garbitu” botoiak aktibatzen dira.
 - Kalkulatu botoia sakatzean, 5 zenbakien batuketa erakusten da MessageBox batean.
 - Garbitu botoia sakatzean, aplikazioa hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.

Klase bat egin, Zenbakia izenekoa:
 - Propietate bat soilik irakurtzeko: EmaitzaOsoa.
 - Metodo bat: SetEmaitzaOsoa(float n) → sarrerako zenbakia gehitzen du barneko akumulagailura.
*/

namespace Gehigarria_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEmaitza.Enabled = false;
            btnGarbitu.Enabled = false; 
            btnZenbaki2.Enabled = false;
            btnZenbaki3.Enabled = false;
            btnZenbaki4.Enabled = false;
            btnZenbaki5.Enabled = false;
        }
        Batuketa batuketa = new Batuketa();
        private void btnZenbaki1_Click(object sender, EventArgs e)
        {
            batuketa.SetEmaitzaOsoa(float.Parse(tbZenbakia.Text));
            Console.WriteLine(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki1.Enabled = false;
            btnZenbaki2.Enabled = true;
            tbZenbakia.Clear();
        }

        private void btnZenbaki2_Click(object sender, EventArgs e)
        {
            batuketa.SetEmaitzaOsoa(float.Parse(tbZenbakia.Text));
            Console.WriteLine(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki2.Enabled = false;
            btnZenbaki3.Enabled = true;
            tbZenbakia.Clear();
        }

        private void btnZenbaki3_Click(object sender, EventArgs e)
        {
            batuketa.SetEmaitzaOsoa(float.Parse(tbZenbakia.Text));
            Console.WriteLine(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki3.Enabled = false;
            btnZenbaki4.Enabled = true;
            tbZenbakia.Clear();
        }

        private void btnZenbaki4_Click(object sender, EventArgs e)
        {
            batuketa.SetEmaitzaOsoa(float.Parse(tbZenbakia.Text));
            Console.WriteLine(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki4.Enabled = false;
            btnZenbaki5.Enabled = true;
            tbZenbakia.Clear();
        }

        private void btnZenbaki5_Click(object sender, EventArgs e)
        {
            batuketa.SetEmaitzaOsoa(float.Parse(tbZenbakia.Text));
            Console.WriteLine(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki5.Enabled = false;
            btnGarbitu.Enabled = true;
            btnEmaitza.Enabled = true;
            tbZenbakia.Clear();
        }

        private void btnEmaitza_Click(object sender, EventArgs e)
        {
            MessageBox.Show(batuketa.EmaitzaOsoa.ToString("0.00"));
            btnZenbaki1.Enabled = true;
            btnGarbitu.Enabled = false;
            btnEmaitza.Enabled = false;
            tbZenbakia.Clear();
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            btnGarbitu.Enabled = false;
            btnEmaitza.Enabled = false;
            tbZenbakia.Clear();
            batuketa = new Batuketa(); 
        }
    }
}
