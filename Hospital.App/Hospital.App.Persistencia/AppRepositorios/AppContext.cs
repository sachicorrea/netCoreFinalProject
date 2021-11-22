using Microsoft.EntityFrameworkCore;
using Hospital.App.Dominio;

namespace Hospital.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get;set;}
        public DbSet<SignoVital> SignosVitales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Initial Catalog=HospitalSenaData; Data Source=DESKTOP-0LR80JT; Integrated Security=true");
            }            
        }
    }
}