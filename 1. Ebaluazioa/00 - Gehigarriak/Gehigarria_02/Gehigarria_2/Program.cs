/*
 Ariketa 2: Sortu hitzak biltzeko aplikazioa.
 - Hasieran “Hitza1” botoia bakarrik aktibatuta dago.
 - Testu kutxan lehenengo hitza idatzi eta Hitza1 botoia sakatzean → hau desaktibatuta geratzen da eta Hitza2 aktibatuta.
 - Horrela jarraitzen da Hitza3 arte.
 - Hirugarren botoia sakatu ondoren, “Invertitu” eta “Garbitu” botoiak aktibatzen dira.
 - Invertitu botoia sakatzean, 3 hitzak ordenaren alderantziz erakusten dira MessageBox batean, tarte zuri batekin bereizita.
 - Garbitu botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da.

Klase bat egin, Hitza izenekoa:

 - Barnean lista pribatu bat edukiko du hitzak gordetzeko.
 - Propietate bat soilik irakurtzeko: Inverso (hitz guztiak alderantziz concatenatuta).
 - Metodo bat: AddHitza(string testua) --> hitza listan gehitzen du.
 */

namespace Gehigarria_2
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
    
}