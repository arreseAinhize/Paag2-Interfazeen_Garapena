namespace HerentzienAriketa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Kontaktua
    {
        // Propietateak
        public string Nan { get; set; }
        public string Izena { get; set; }
        public string Abizena { get; set; }

        // Emaila propietate virtuala
        public virtual string Emaila { get; set; }

        // IzenOsoa propietate irakurtzeko soilik
        public string IzenOsoa
        {
            get { return $"{Izena} {Abizena}"; }
        }

        // Eraikitzailea
        public Kontaktua() { }

        public Kontaktua(string nan, string izena, string abizena, string emaila)
        {
            this.Nan = nan;
            this.Izena = izena;
            this.Abizena = abizena;
            this.Emaila = emaila;
        }

        //Metodoak
        public virtual String Gorde(){ 
            return $"Kontaktua gorde da: {IzenOsoa}, NAN: {Nan}, Emaila: {Emaila}";
        } 
    }

    public class Bezeroa : Kontaktua {
        public string Kategoria { get; set; }
        public override string Gorde() {
            return "Bezeroa ondo gorde da";
        }

        // Eraikitzaileak
        public Bezeroa() { }
        public Bezeroa(string nan, string izena, string abizena, string emaila, string kategoria) : base(nan, izena, abizena, emaila){
            this.Kategoria = kategoria;
        }

    }
    public class Langile : Kontaktua{
        // Propietate berriak
        public decimal Soldata { get; set; }
        public string SegurtasunSoziala { get; set; }

        // Emaila propietatea berriro definitzen (override)
        private string _emaila;
        public override String Emaila
        {
            get { return _emaila; }
            set
            {
                if(value.Substring(value.Length - 14, 14) != "@iesunibhi.com"){
                    Exception ex = new Exception("Emaila ez duzu ondo jarri"); throw ex; 
                }
            }
        }

        // Eraikitzaileak
        public Langile() { }

        public Langile(string nan, string izena, string abizena, string emaila,  decimal soldata, string segurtasunSoziala) : base(nan, izena, abizena, emaila)
        {
            Soldata = soldata;
            SegurtasunSoziala = segurtasunSoziala;

            // Emaila propietatea egiaztatzeko
            
            _emaila = emaila;
        }

        public override string Gorde(){
            return "Langilea ondo gorde da";
        }
    }
}