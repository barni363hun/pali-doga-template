using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vizsga
{
    public class AppContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=vizsga;uid=root;pwd=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProfessionModel>().HasIndex(p => p.Name).IsUnique();

            //modelBuilder.Entity<ProfessionModel>().HasData(
            //    new ProfessionModel() { Id = 1, Name= "Szoftverfejlesztő és tesztelő" },
            //    new ProfessionModel() { Id = 2, Name= "Informatikai rendszer- és alkalmazás üzemeltető" },
            //    new ProfessionModel() { Id = 3, Name= "CAD-CAM informatikus" },
            //    new ProfessionModel() { Id = 4, Name= "Gépgyártástechnológiai technikus" },
            //    new ProfessionModel() { Id = 5, Name= "Gazdasági informatikus" }
            //) ;

        }
    }
}
