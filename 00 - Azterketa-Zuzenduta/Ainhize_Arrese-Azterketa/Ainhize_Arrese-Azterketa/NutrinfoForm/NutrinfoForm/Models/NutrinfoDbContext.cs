using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    public class NutrinfoDbContext : DbContext
    {
        public NutrinfoDbContext() : base(" name = NutrinfoDbContext ") { }
        public DbSet<Osagaia> osagaia { get; set; }
        public DbSet<Informazioa> informazioa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // FUNTZIONATZEKO FALTA ZEN ATALAREN HASIERA
            // Configurar FK explícita
            modelBuilder.Entity<Informazioa>()
                .HasRequired(i => i.osagaia)
                .WithMany(o => o.informazioLista)
                .HasForeignKey(i => i.OsagaiaId);

            base.OnModelCreating(modelBuilder);
            // FUNTZIONATZEKO FALTA ZEN ATALAREN BUKAERA
        }
        public static List<Elikagaia> GetElikagaiak()
        {
            try
            {
                using (var db = new NutrinfoDbContext())
                {
                    var sql = @"
                        SELECT * FROM public.""Elikagaia""
                        ORDER BY ""Id"" ASC 
                    ";
                    return db.Database.SqlQuery<Elikagaia>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea gertatu da: " + ex);
                return new List<Elikagaia>();
            }
        }
    }
}
