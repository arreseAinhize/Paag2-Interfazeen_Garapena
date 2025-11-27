using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    public partial class Informazioa
    {
        [Key]
        public int Id { get; set; }
        // FUNTZIONATZEKO FALTA ZEN ATALAREN HASIERA
        // FK definitzea
        [ForeignKey("osagaia")]
        // FUNTZIONATZEKO FALTA ZEN ATALAREN BUKAERA
        public int OsagaiaId { get; set; }
        public int Urtea {  get; set; }
        public int Kantitatea { get; set; }
        public int ElikagaiaId { get; set; }
        public virtual Osagaia osagaia { get; set; }
        public virtual List<Osagaia> osagaienLista { get; set; }
    }
}
