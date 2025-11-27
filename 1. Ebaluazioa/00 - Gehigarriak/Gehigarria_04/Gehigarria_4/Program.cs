/*
 Ariketa 4: Sortu hirien aplikazioa.

 - Hasieran “Hiria1” botoia bakarrik aktibatuta dago.
 - Testu kutxan lehenengo hiriaren izena idatzi eta Hiria1 botoia sakatzean --> hau desaktibatuta geratzen da eta Hiria2 aktibatuta.
 - Horrela jarraitzen da Hiria3–Hiria5 arte.
 - Bostgarren botoia sakatu ondoren, “Lotu” eta “Garbitu” botoiak aktibatzen dira.
 - Lotu botoia sakatzean, 5 hiriak erakusten dira MessageBox batean, bakoitza lerro berrian.

Bilbao  
Donostia  
Gasteiz  
Iruña  
Baiona

 - Garbitu botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.

Klasea: Hiria
 - Barnean lista pribatu bat edukiko du hirien izenak gordetzeko.
 - Propietate bat soilik irakurtzeko: Guztiak (hiri guztiak string batean itzultzen ditu, \n bidez bereizita).
 - Metodo bat: AddHiria(string izena) --> hiria listan gehitzen du.
 */
namespace Gehigarria_4
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