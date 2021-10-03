using Microsoft.EntityFrameworkCore;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas {get;set;}
       public DbSet<Paciente> Pacientes {get;set;}
       public DbSet<Medico> Medico {get;set;}
       public DbSet<Encuesta> Encuestas {get;set;}
       public DbSet<Cita> Citas {get;set;}
       public DbSet<Sede> Sedes {get;set;}
       public DbSet<Facturacion> Facturaciones {get;set;}
       public DbSet<Convenio> Convenios {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendamientoIPSData");
               .UseSqlServer("Data Source = localhost; Initial Catalog = AgendamientoIPS; User Id = SA; Password = 2805.GabTT.");
           }
       }
   }   
}