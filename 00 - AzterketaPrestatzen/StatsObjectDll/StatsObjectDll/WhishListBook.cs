using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsObjectDll
{
    public partial class WhishListBook
    {
        public string title { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        public string status { get; set; }

        public WhishListBook() { }
        public WhishListBook(string title, string author, int price, string status)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.status = status;
        }
    }
}
