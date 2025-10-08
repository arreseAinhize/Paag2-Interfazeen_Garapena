namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            // variableMota.parse <-- Datuak motaz aldatzeko kasu honetan de String a float
            // VariableIzena.Text <-- textBox-en idatzite dauena hartzeko. 
            /* BESTE MODU BAT
             * float zenb1 = float.parse(tbZenbakia1.Text);
             * float zenb1 = float.parse(tbZenbakia2.Text);
             * Kalkulagailua kalkulagailua = new Kalkulagailua(zenb1,zenb2); 
             */
            Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(tbZenbakia1.Text), float.Parse(tbZenbakia2.Text));
            MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00")); // ToString bitartez ze motatako emaitza bieltatzea nahi dogun esaten dau.
            // Kasu honetan decimalen gehiketa denez, 3.5 + 1.25 = 4.75 emateko "0.00" jarri behar da bestela 465 bueltatzen du. 
        }

        private void btnKendu_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(tbZenbakia1.Text), float.Parse(tbZenbakia2.Text));
            MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
        }

        private void btnBidertu_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(tbZenbakia1.Text), float.Parse(tbZenbakia2.Text));
            MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
        }
        private void btnZatitu_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua(float.Parse(tbZenbakia1.Text), float.Parse(tbZenbakia2.Text));
            MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
        }

        private void tb1idatzi(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }else            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (tbZenbakia1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (tbZenbakia1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void tbIdatzi2(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
               && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
               && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
               && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (tbZenbakia2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (tbZenbakia2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }

}
