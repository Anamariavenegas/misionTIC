using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Estaciones> Estaciones { get; set; }
        public DbSet<Rutas> Rutas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = misiontic-avp.database.windows.net; Initial Catalog = ProyectoCiclo3; User ID=admin_avenegasp;Password=Nanis.0205");
            }
        }
    }
}
