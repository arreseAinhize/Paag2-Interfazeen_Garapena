using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsObjectDll
{
    public partial class ReadingBookLog
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime? StartReading { get; set; }
        public DateTime? EndReading { get; set; }
        public ReadingBookLog() { }
        public ReadingBookLog( string title, string author, DateTime startReading, DateTime endReading)
        {
            Title = title;
            Author = author;
            StartReading = startReading;
            EndReading = endReading;
        }   

        public string ToString()
        {
            return $"{Title} by {Author}, from {StartReading?.ToShortDateString()} to {EndReading?.ToShortDateString()}";
        }
    }
}
