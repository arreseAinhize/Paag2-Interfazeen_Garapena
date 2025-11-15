using StatsObjectDll;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AzterketaPrestatzen1.Models
{
    // internal aldatu eta public bihurtu, DbContext klaseraren "ahur" bihurtu
    public class BookJournalDbContext : DbContext
    {
        public BookJournalDbContext() :base("name = BookJournalDbContext"){}

        public static List<Gastuak> GetGastuak()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    // Zutabeen izenak objetuko propietateen izenekin bat etorri behar dira AS egitean
                    string sql = @"
                        SELECT
                          EXTRACT(YEAR FROM w.data)::int AS Urtea,
                          EXTRACT(MONTH FROM w.data)::int AS Hilabetea,
                          SUM(w.prezioa) AS Prezioa
                        FROM Wishlist w
                        WHERE w.prezioa IS NOT NULL
                          AND w.prezioa > 0
                          AND w.erosita = 'Bai'
                        GROUP BY urtea, hilabetea
                        ORDER BY urtea, hilabetea;
                    ";
                                        return db.Database.SqlQuery<Gastuak>(sql).ToList();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
                return new List<Gastuak>();
            }
        }
    }
}
