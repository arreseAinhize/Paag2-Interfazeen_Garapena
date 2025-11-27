using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    public partial class Elikagaia
    {
        public int id { get; set; }
        public string izena { get; set; }
        public string marka { get; set; }

        public Elikagaia() { }

        public Elikagaia(int id, string izena, string marka)
        {
            this.id = id;
            this.izena = izena;
            this.marka = marka;
        }
    }
}
