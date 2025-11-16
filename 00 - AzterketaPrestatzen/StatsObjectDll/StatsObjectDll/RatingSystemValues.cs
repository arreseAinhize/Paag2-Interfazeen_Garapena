using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsObjectDll
{
    public partial class RatingSystemValues
    {
        public string star1 { get; set; }
        public string star2 { get; set; }
        public string star3 { get; set; }
        public string star4 { get; set; }
        public string star5 { get; set; }
        public RatingSystemValues() { }
        public RatingSystemValues(string star5, string star4, string star3, string star2, string star1)
        {
            this.star1 = star1;
            this.star2 = star2;
            this.star3 = star3;
            this.star4 = star4;
            this.star5 = star5;
        }
        public List<string> AsList()
        {
            return new List<string> { star1, star2, star3, star4, star5 };
        }
    }
}
