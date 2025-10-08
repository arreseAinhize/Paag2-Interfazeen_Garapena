namespace Ariketa2_Formula_V1
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
        // Atributuak (float motako zenbakiak gordetzeko)
        private float zenb1;
        private float zenb2;
        private float zenb3;
        private float zenb4;

        // Eragiketaren emaitza gordetzeko atributua
        private float emaitza;
        private string emaitzaString;
        // Metodoa zenbakiak ezartzeko. Switch/case egitura erabil dezakegu,
        // ariketaren sekuentzia (1. zenbakia, 2. zenbakia, ...) simulatuz.
        // 'posizioa' aldagaiak zein zenbaki ezarri behar den adierazten du.
        public void EzarriZenbakia(int posizioa, float balioa)
        {
            switch (posizioa)
            {
                case 1:
                    zenb1 = balioa;
                    break;
                case 2:
                    zenb2 = balioa;
                    break;
                case 3:
                    zenb3 = balioa;
                    break;
                case 4:
                    zenb4 = balioa;
                    break;
                default:
                    // Aukerakoa: errore mezu bat edo beste ekintza bat
                    Console.WriteLine("Posizioa ez da zuzena. (1-4)");
                    break;
            }
        }

        // Eragiketa kalkulatzeko metodoa
        public float KalkulatuEragiketa()
        {
            // (a+2b+3c+4d)/4 formula aplikatuz
            emaitza = (zenb1 + (2 * zenb2) + (3 * zenb3) + (4 * zenb4)) / 4.0f;
            return emaitza;
        }

        public string EmaitzaString()
        {
            // (a+2b+3c+4d)/4 formula aplikatuz
            emaitzaString = $"({zenb1} + (2 * {zenb2}) + (3 * {zenb3}) + (4 * {zenb4})) / 4 = {emaitza.ToString("0.00")}";
            // Berdiña beste era batera: emaitzaString = $"( {z1} + (2 * {z2}) + (3 * {z3}) + (4 * {z4})) / 4 = {emaitza:0.00}";
            return emaitzaString;
        }

        // Klasearen egoera hasierako puntura itzultzeko metodoa, "Garbitu" botoiaren funtzioa eginez
        public void Garbitu()
        {
            zenb1 = 0.0f;
            zenb2 = 0.0f;
            zenb3 = 0.0f;
            zenb4 = 0.0f;
            emaitza = 0.0f;
        }
    }
}