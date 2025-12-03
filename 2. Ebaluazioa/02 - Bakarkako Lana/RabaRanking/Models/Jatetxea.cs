namespace RabaRanking.Models
{
    public class Jatetxea
    {
        public Jatetxea(string izena, string herria, double puntuazioa, int pozisioa)
        {
               Izena = izena;
               Herria = herria;
               Puntuazioa = puntuazioa;
               Pozisioa = pozisioa;
        }
        public string Izena { get; set; }
        public string Herria { get; set; }
        public double Puntuazioa { get; set; }
        public int Pozisioa { get; set; }
        public virtual string Helbidea { get; set; }
        public virtual string Gorde()
        {
            return "Jatetxea ondo gorde da.";
        }
    }
}
