using AzterketaPrestatzen1.Models;
using StatsObjectDll;
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
    public partial class ReadingStats : UserControl
    {
        public ReadingStats()
        {
            InitializeComponent();
            gastuDirua1.Grafikoa_Marraztu(BookJournalDbContext.GetGastuak()); //GrafikoLinealera datuak bidaltzen
            puntuazioBanaketa1.Grafikoa_Marraztu(BookJournalDbContext.GetPuntuak());
            totPag.Text = BookJournalDbContext.GetTotalPages().ToString();
        }
    }
}
