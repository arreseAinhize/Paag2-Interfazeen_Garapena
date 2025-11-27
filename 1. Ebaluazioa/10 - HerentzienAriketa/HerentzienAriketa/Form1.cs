namespace HerentzienAriketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Datuak jaso
            String nan = tbNan.Text;
            String izena = tbIzena.Text;
            String abizena = tbAbizena.Text;
            String emaila = tbEmail.Text;

            // Eremu hutsak balidatzen
            if (!DatuakOndoJarrita(nan, izena, abizena, emaila))
            {
                return;
            }

            if (cbBezeroa.Checked)
            {
                if (cbLangilea.Checked || cbKontaktua.Checked)
                {
                    MessageBox.Show("Aukera bakarra izan daiteke!");
                }
                else
                {
                    String kategoria = combKategora.Text;
                    if (string.IsNullOrEmpty(kategoria))
                    {
                        MessageBox.Show("Kategoria aukeratu behar duzu!");
                        return;
                    }

                    Bezeroa bezeroa = new Bezeroa(nan, izena, abizena, emaila, kategoria);
                    MessageBox.Show(bezeroa.Gorde());
                }
            }
            else if (cbLangilea.Checked)
            {
                if (cbBezeroa.Checked || cbKontaktua.Checked)
                {
                    MessageBox.Show("Aukera bakarra izan daiteke!");
                }
                else
                {
                    string soldata = tbSoldata.Text.Trim();
                    string ss = tbSerguSoziala.Text.Trim();

                    // Langilearen datu gehigarriak balidatzen
                    if (!LangileDatuakOndoJarrita(soldata, ss))
                    {
                        return;
                    }

                    try
                    {
                        Langile langilea = new Langile(nan, izena, abizena, emaila, Convert.ToDecimal(soldata), ss);
                        MessageBox.Show(langilea.Gorde());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Soldata zenbaki baliagarria izan behar da!", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errorea: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (cbKontaktua.Checked)
            {
                if (cbBezeroa.Checked || cbLangilea.Checked)
                {
                    MessageBox.Show("Aukera bakarra izan daiteke!");
                }
                else
                {
                    Kontaktua kontaktua = new Kontaktua(nan, izena, abizena, emaila);
                    MessageBox.Show(kontaktua.Gorde());
                }
            }
            else
            {
                MessageBox.Show("Aukeratu mota bat!");
            }
        }

        // Datuak hutsik dauden egiaztatzen
        private bool DatuakOndoJarrita(string nan, string izena, string abizena, string emaila)
        {
            if (string.IsNullOrEmpty(nan))
            {
                MessageBox.Show("NAN eremua ezin da hutsik egon!");
                tbNan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(izena))
            {
                MessageBox.Show("Izena eremua ezin da hutsik egon!");
                tbIzena.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(abizena))
            {
                MessageBox.Show("Abizena eremua ezin da hutsik egon!");
                tbAbizena.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(emaila))
            {
                MessageBox.Show("Emaila eremua ezin da hutsik egon!");
                tbEmail.Focus();
                return false;
            }

            return true;
        }

        // Langilearen datu gehigarriak balidatzen
        private bool LangileDatuakOndoJarrita(string soldata, string segurtasunSoziala)
        {
            if (string.IsNullOrEmpty(soldata))
            {
                MessageBox.Show("Soldata eremua ezin da hutsik egon!");
                tbSoldata.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(segurtasunSoziala))
            {
                MessageBox.Show("Segurtasun Soziala eremua ezin da hutsik egon!");
                tbSerguSoziala.Focus();
                return false;
            }

            // Soldata zenbaki baliagarria den egiaztatzen
            if (!decimal.TryParse(soldata, out decimal soldataDecimal))
            {
                MessageBox.Show("Soldata zenbaki baliagarria izan behar da!", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSoldata.Focus();
                return false;
            }

            // Soldata positiboa den egiaztatzen
            if (soldataDecimal <= 0)
            {
                MessageBox.Show("Soldata 0 baino handiagoa izan behar da!", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSoldata.Focus();
                return false;
            }

            return true;
        }

        // CheckBox-ak elkarrekiko esklusiboak egiteko
        private void cbBezeroa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBezeroa.Checked)
            {
                cbLangilea.Checked = false;
                cbKontaktua.Checked = false;
                combKategora.Enabled = true;
                tbSoldata.Enabled = false;
                tbSerguSoziala.Enabled = false;
            }
        }

        private void cbLangilea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLangilea.Checked)
            {
                cbBezeroa.Checked = false;
                cbKontaktua.Checked = false;
                combKategora.Enabled = false;
                tbSoldata.Enabled = true;
                tbSerguSoziala.Enabled = true;
            }
        }

        private void cbKontaktua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKontaktua.Checked)
            {
                cbBezeroa.Checked = false;
                cbLangilea.Checked = false;
                combKategora.Enabled = false;
                tbSoldata.Enabled = false;
                tbSerguSoziala.Enabled = false;
            }
        }

        // Testu-kutxetan sartutako datuak mugatzen (zenbakiak soilik soldatan)
        private void tbSoldata_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Zenbakiak, kontrol-teklak eta koma/puntua baimendu
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Koma/puntu bakarra baimendu
            if ((e.KeyChar == ',' || e.KeyChar == '.') && tbSoldata.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        // Form-a irekitzean kontrolak hasieratzen
        private void Form1_Load(object sender, EventArgs e)
        {
            combKategora.Enabled = false;
            tbSoldata.Enabled = false;
            tbSerguSoziala.Enabled = false;
        }
    }
