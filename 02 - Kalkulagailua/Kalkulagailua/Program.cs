namespace Kalkulagailua
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

    internal class Kalkulagailua
    {
        //Propietateak
        public float zenbakia1 { get; set; }
        public float zenbakia2 { get; set; }

        //Eraikitzaileak
        public Kalkulagailua(float zenb1, float zenb2){
            //Bi propiedadee sortu duguz (zenbakia1 eta zenbakia2), thi. <-- referentzia eitten dotzau klase horretan sortutako propietateari.
            //Kasu honetan, jasotako parametroak (zenb1 eta zenb2) aurretik sortutako klaseko parametroetan gorde nahi doguz (this.zenbakia1 eta this.zenbakia2)
            this.zenbakia1 = zenb1; 
            this.zenbakia2 = zenb2;
        }

        //Metodoak
        public float Gehiketa()
        {
            float emaitza;
            emaitza = zenbakia1 + zenbakia2;
            return emaitza;
        }

        public float Kenketa()
        {
            float emaitza;
            emaitza = zenbakia1 - zenbakia2;
            return emaitza;
        }

        public float Biderketa()
        {
            float emaitza;
            emaitza = zenbakia1 * zenbakia2;
            return emaitza;
        }

        public float Zatiketa()
        {
            float emaitza;
            emaitza = zenbakia1 / zenbakia2;
            return emaitza;
        }
    }
}