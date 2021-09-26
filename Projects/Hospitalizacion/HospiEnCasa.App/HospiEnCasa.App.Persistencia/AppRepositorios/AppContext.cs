using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio.Entidades;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set;}
        public DbSet<Medico> medicos { get; set; }
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> familiaresDesignados { get; set;}
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Remision> Remisiones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=HospiEnCasaData;user=root;password=7111").EnableSensitiveDataLogging(true);
            }
        }
    }
}