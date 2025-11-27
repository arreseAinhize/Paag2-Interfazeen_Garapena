using System.Runtime.InteropServices;

namespace Ariketa_2
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
    public class Zenbakia
    {
        public float emaitza;
        public string emaitzaString;
        public float sartutakoZenbakia { get; set; }

        public Zenbakia(float sartutakoZenbakia) {
            this.sartutakoZenbakia = sartutakoZenbakia;
        }
        public void SetEmaitza(Zenbakia[] zenbakiak)
        {
            emaitza = (zenbakiak[0].sartutakoZenbakia + (2 * zenbakiak[1].sartutakoZenbakia) + (3 * zenbakiak[2].sartutakoZenbakia) + (4 * zenbakiak[3].sartutakoZenbakia)) / 4;
        }
        public string GetEmaitzaString(Zenbakia[] zenbakiak)
        {
            emaitzaString = $"( {zenbakiak[0].sartutakoZenbakia} + ({zenbakiak[1].sartutakoZenbakia} * 2 ) + ({zenbakiak[2].sartutakoZenbakia} * 3) + ({zenbakiak[3].sartutakoZenbakia} * 4) ) / 4 = " + emaitza.ToString("0.00");
            // Berdiña beste era batera: emaitzaString = $"( {z1} + (2 * {z2}) + (3 * {z3}) + (4 * {z4})) / 4 = {emaitza:0.00}";
            return emaitzaString;
        }
    }
}