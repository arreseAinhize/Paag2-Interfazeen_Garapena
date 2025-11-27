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
        public BookJournalDbContext() : base("name = BookJournalDbContext"){}
        // RatingSystem-ek erabiltzen dituen DbSet-ak hemen definiatu
        public static RatingSystemValues GetRatingSystem()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        Select 
                            star_1 as Star1, 
                            star_2 as Star2, 
                            star_3 as Star3, 
                            star_4 as Star4, 
                            star_5 as Star5
                        From RatingValur
                    ";
                    return db.Database.SqlQuery<RatingSystemValues>(sql).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertstu da:" + ex);
                return new RatingSystemValues();
            }
        }

        // Datu baseko tauletako bat eguneratu, aginte koadrotik datuak pasatuz
        public static void UpdateRatingSystem(RatingSystemValues newValues)
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        UPDATE RatingValur
                        SET 
                            star_1 = @p0,
                            star_2 = @p1,
                            star_3 = @p2,
                            star_4 = @p3,
                            star_5 = @p4
                    ";
                    db.Database.ExecuteSqlCommand(sql,
                        newValues.star1,
                        newValues.star2,
                        newValues.star3,
                        newValues.star4,
                        newValues.star5);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
            }
        }

        // Reading Log-ek erabiltzen dituen DbSet-ak hemen definiatu
        public static List<ReadingBookLog> GetReadingLog()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        SELECT 
                            b.title as Title, 
                            b.author as Author,
                            r.startdate as StartReading, 
                            r.enddate as EndReading
                        FROM Book b
                        LEFT JOIN Review r ON b.id = r.bookid;";
                    return db.Database.SqlQuery<ReadingBookLog>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
                return new List<ReadingBookLog>();
            }
        }
        
        // WishList-ek erabiltzen dituen DbSet-ak hemen definiatu
        public static List<WhishListBook> GetWishList()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        SELECT 
                            w.title as title, 
                            w.author as author,
                            w.prezioa as price,
                            w.erosita as status
                        FROM Wishlist w;";
                    return db.Database.SqlQuery<WhishListBook>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
                return new List<WhishListBook>();
            }
        }

        // Reading stats-ek erabiltzen dituen metodoak hemen definiatu
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
    
        public static Puntuak GetPuntuak()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        WITH Label AS (
                            SELECT 
                                star_1 AS star1,
                                star_2 AS star2,
                                star_3 AS star3,
                                star_4 AS star4,
                                star_5 AS star5
                            FROM RatingValur
                            LIMIT 1
                        ),
                        Counts AS (
                            SELECT rating, COUNT(*) AS total
                            FROM Review
                            GROUP BY rating
                        )
                        SELECT
                            COALESCE((SELECT total FROM Counts c JOIN Label l ON c.rating = l.star1), 0) AS Star1,
                            COALESCE((SELECT total FROM Counts c JOIN Label l ON c.rating = l.star2), 0) AS Star2,
                            COALESCE((SELECT total FROM Counts c JOIN Label l ON c.rating = l.star3), 0) AS Star3,
                            COALESCE((SELECT total FROM Counts c JOIN Label l ON c.rating = l.star4), 0) AS Star4,
                            COALESCE((SELECT total FROM Counts c JOIN Label l ON c.rating = l.star5), 0) AS Star5
                    ";
                    return db.Database.SqlQuery<Puntuak>(sql).FirstOrDefault();
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Errorea datuak eskuratzean" + ex);
                return new Puntuak();
            }
        }
    
        public static int GetTotalPages()
        {
            try
            {
                using (var db = new BookJournalDbContext())
                {
                    var sql = @"
                        SELECT 
                            COALESCE(SUM(duration), 0) AS TotalPages
                        FROM Book
                        WHERE duration IS NOT NULL AND duration > 0
                    ";
                    return db.Database.SqlQuery<int>(sql).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
                return 0;
            }
        }
    }
}
