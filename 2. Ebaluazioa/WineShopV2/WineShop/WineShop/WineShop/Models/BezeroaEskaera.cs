using System.ComponentModel.DataAnnotations;

namespace WineShop.Models
{
    public class BezeroaEskaera
    {
        [Key]

        // Bezeroaren ID automatikoki sortzen da eta ez da formularioan erakutsiko
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        // Bezeroaren izena derigorrezkoa da
        [Required(ErrorMessage = "Izena derrigorrezkoa da")]
        public string Izena { get; set; }

        // Bezeroaren abizena derigorrezkoa da
        [Required(ErrorMessage = "Abizena derrigorrezkoa da")]
        public string Abizena { get; set; }

        // Bezeroaren helbidea derigorrezkoa da
        [Required(ErrorMessage = "Helbidea derrigorrezkoa da")]
        public string Helbidea { get; set; }

        // Bezeroaren hiria derigorrezkoa da
        [Required(ErrorMessage = "Hiria derrigorrezkoa da")]
        public string Hiria { get; set; }

        // Bezeroaren herrialdea derigorrezkoa da
        [Required(ErrorMessage = "Herrialdea derrigorrezkoa da")]
        public string Herrialdea { get; set; }

        // Bezeroaren postakodea derigorrezkoa da
        [Required(ErrorMessage = "Postakodea derrigorrezkoa da")]
        public string Postakodea { get; set; }

        // Bezeroaren telefonoa derigorrezkoa da
        [Required(ErrorMessage = "Telefonoa derrigorrezkoa da")]
        public string Telefonoa { get; set; }

        // Data automatikoki sortzen da eta ez da formularioan erakutsiko
        [ScaffoldColumn(false)]
        public System.DateTime Data { get; set; }

        // Bezeroaren erabiltzailea ez da formularioan erakutsiko, kanpo hau existitu ahal da edo ez.
        [ScaffoldColumn(false)]
        public string? Erabiltzailea { get; set; }

    }
}
