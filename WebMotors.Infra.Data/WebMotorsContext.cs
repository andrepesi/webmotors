using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain;

namespace WebMotors.Infra.Data
{
    public class WebMotorsContext : DbContext
    {
        public WebMotorsContext(): base("webmtrconnstr")
        {

        }
        public DbSet<Anuncio> Anuncios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnuncioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
