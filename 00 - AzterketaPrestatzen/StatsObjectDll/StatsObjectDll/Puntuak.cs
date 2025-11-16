using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsObjectDll
{
    public partial class Puntuak
    {
        int star1 { get; set; }
        int star2 { get; set; }
        int star3 { get; set; }
        int star4 { get; set; }
        int star5 { get; set; }
        public Puntuak() { }

        public Puntuak(int star1, int star2, int star3, int star4, int star5)
        {
            this.star1 = star1;
            this.star2 = star2;
            this.star3 = star3;
            this.star4 = star4;
            this.star5 = star5;
        }

        public List<int> AsList()
        {
            return new List<int> { star1, star2, star3, star4, star5 };
        }
    }
}
