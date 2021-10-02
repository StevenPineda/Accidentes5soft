using Microsoft.EntityFrameworkCore;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia{

    public class AppContext:DbContext{

        public DbSet<Accidente> Accidentes  {get;set;}
        public DbSet<AgenteTransito> Agente  {get;set;}
        public DbSet<Historia> Historia  {get;set;}
        public DbSet<Involucrado> Involucrados  {get;set;}
        public DbSet<Persona> Personas  {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-5A0CU2A\\SQLEXPRESSASUS; Initial Catalog =DBACCIDENTETRANSITO;Integrated Security=False ;User ID=sa;Password=@SUSjr2021*;");
            }   
        }   
    }
}

///"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =DBACCIDENTETRANSITO"
//.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =AccidenteTransitotData");