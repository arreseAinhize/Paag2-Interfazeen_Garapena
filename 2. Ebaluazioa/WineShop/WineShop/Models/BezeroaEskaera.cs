using System.ComponentModel.DataAnnotations;

namespace WineShop.Models
{
    public class BezeroaEskaera
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Izena derrigorrezkoa da")]
        public string Izena { get; set; }
        [Required(ErrorMessage = "Abizena derrigorrezkoa da")]
        public string Abizena { get; set; }
        [Required(ErrorMessage = "Helbidea derrigorrezkoa da")]
        public string Helbidea { get; set; }
        [Required(ErrorMessage = "Hiria derrigorrezkoa da")]
        public string Hiria { get; set; }

        // Herrialdea derrigorrezkoa da, baina ez da formatu zehatzik eskatzen.
        [Required(ErrorMessage = "Herrialdea derrigorrezkoa da")]
        public string Herrialdea { get; set; }

        // Postakodea derrigorrezkoa da, baina ez da formatu zehatzik eskatzen.
        [Required(ErrorMessage = "Postakodea derrigorrezkoa da")]
        public string Postakodea { get; set; }

        // Telefonoa derrigorrezkoa da, baina ez da formatu zehatzik eskatzen.
        [Required(ErrorMessage = "Telefonoa derrigorrezkoa da")] 
        public string Telefonoa { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime Data { get; set; }

        // Erabiltzailea ez da formularioan sartzen, beraz, ez da derrigorrezkoa. (Baina baliteke behar izatea datu basean gordetzeko)
        [ScaffoldColumn(false)]
        public string? Erabiltzailea { get; set; }
    }
}
