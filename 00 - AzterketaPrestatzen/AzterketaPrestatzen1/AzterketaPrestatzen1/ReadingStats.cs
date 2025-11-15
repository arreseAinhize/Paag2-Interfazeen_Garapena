using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatsObjectDll;

namespace AzterketaPrestatzen1
{
    public partial class ReadingStats : UserControl
    {
        List<Gastuak> gastuLista = new List<Gastuak>
        {
            new Gastuak(2025, 1, 35.90m),
            new Gastuak(2025, 2, 19.95m),
            new Gastuak(2025, 3, 12.00m)
        };
        Puntuak puntuak = new Puntuak(56, 32, 12, 3, 45);
        public ReadingStats()
        {
            InitializeComponent();
            gastuDirua1.Grafikoa_Marraztu(gastuLista);
            puntuazioBanaketa1.Grafikoa_Marraztu(puntuak);
        }
    }
}
