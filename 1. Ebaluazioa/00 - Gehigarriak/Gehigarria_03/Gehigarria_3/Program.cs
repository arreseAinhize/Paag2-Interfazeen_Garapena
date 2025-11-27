/*
 Ariketa 3: Sortu ikasleen notak kudeatzeko aplikazioa.

 - Hasieran “Nota1” botoia bakarrik aktibatuta dago.
 - Testu kutxan lehenengo nota (0–10 bitartean) idatzi eta Nota1 botoia sakatzean --> hau desaktibatuta geratzen da eta Nota2 aktibatuta.
 - Horrela jarraitzen da Nota4 arte.
 - Laugarren botoia sakatu ondoren, “Media” eta “Reset” botoiak aktibatzen dira.
 - Media botoia sakatzean, 4 noten batezbestekoa erakusten da MessageBox batean (adib. “Batezbestekoa: 7.25”).
 - Reset botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.

Klase bat egin, Nota izenekoa:

 - Barnean lista pribatu bat edukiko du notak gordetzeko.
 - Propietate bat soilik irakurtzeko: Media (double gisa).
 - Metodo bat: AddNota(double n) --> nota listan gehitzen du.
 */
namespace Gehigarria_3
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