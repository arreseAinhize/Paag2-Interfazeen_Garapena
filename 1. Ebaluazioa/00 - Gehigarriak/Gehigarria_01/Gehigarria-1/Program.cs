namespace Gehigarria_1
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
    public class Batuketa
    {
        public float emaitzaOsoa;

        public float Zenbakia { get; set; }

        public float EmaitzaOsoa{ get { return this.emaitzaOsoa; } }

        public void SetEmaitzaOsoa(float zenbakia)
        {
            emaitzaOsoa += zenbakia;
        }
    }
}