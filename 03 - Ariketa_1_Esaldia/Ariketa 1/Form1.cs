namespace Ariketa_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnGarbitu.Enabled = false;
            btnLotu.Enabled = false;
        }
        //public string esaldiOsoa =""; <-- bizitza kompliketie ezertarako ebz
        Esaldia esaldia = new Esaldia(); //datue gordetzen jueteko entre click y click

        private void btnEsaldi1_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text); //<--kasu honetan .ToString() ez da beharrezkoa, .Text-kin tbEsaldia-tik string motako valioak hartzen doguzelako.
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = true;
            tbEsaldia.Clear();
            /* BIZITZA KOMPLIKETIE DA
            Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);
            */
        }

        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text);
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = true;
            tbEsaldia.Clear();
            /* BIZITZA KOMPLIKETIE DA
            Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);
            */
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            /* BIZITZA KOMPLIKETIE DA
            Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);
            */
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text);
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            /* BIZITZA KOMPLIKETIE DA
            Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);
            */
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text);
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            /* BIZITZA KOMPLIKETIE DA
            Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);
            */
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text);
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = true;
            btnGarbitu.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia.esaldiaBatuta); // esaldiaBatuta Pregram.cs-en public delako, bestela (private izango bazan)  .EsaldiaBatuta Erabili biherko genun
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            tbEsaldia.Clear();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnGarbitu.Enabled = false;
            btnLotu.Enabled = false;
            esaldia = new Esaldia(); //Objektua berrezarri
            // esaldia.esaldiaBatuta = "";
        }

        /* BIZITZA KOMPLIKETIE DA
        private void EsaldiOsoa(Esaldia esaldia)
        {
            esaldiOsoa += esaldia.EsaldiaBatuta;
        }
        */
    }
}
