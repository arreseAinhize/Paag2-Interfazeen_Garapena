using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsObjectDll
{
    public partial class Gastuak
    {
        public int Urtea { get; set; }  // Urtea
        public int Hilabetea { get; set; } // Hilabetea
        public decimal Prezioa { get; set; } // Hileko gastuak

        public Gastuak() { }

        public Gastuak(int urtea, int hilabetea, decimal prezioa)
        {
            Urtea = urtea;
            Hilabetea = hilabetea;
            Prezioa = prezioa;
        }

        public string GetMonthLabel()
        {
            // Bueltan: Ene 2025, Feb 2025, etc.
            return new DateTime(Urtea, Hilabetea, 1).ToString("MMM yyyy");
        }

        public static List<Gastuak> gastuak { get; set; } = new List<Gastuak>
        {
            new Gastuak(2025, 1, 35.90m),
            new Gastuak(2025, 2, 19.95m),
            new Gastuak(2025, 3, 12.00m)
        };

    }
}
