using WineShop.Models;

namespace WineShop.ViewModels
{
    public class OsatuViewModel
    {
        public string Bezeroa { get; set; }
        public string SaskiaId { get; set; }
        // public IList<SaskiaAlea> SaskiaAleak { get; set; }
        // SaskiaAleaViewModel zerrenda bat erabiliko dugu
        public IList<SaskiaAleaViewModel> SaskiaAleaVMList { get; set; }

    }
}
