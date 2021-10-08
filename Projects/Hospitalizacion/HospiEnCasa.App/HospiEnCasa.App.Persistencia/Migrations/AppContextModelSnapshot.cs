﻿// <auto-generated />
using System;
using HospiEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospiEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Antecedentes")
                        .HasColumnType("text");

                    b.Property<string>("FechaAtencion")
                        .HasColumnType("text");

                    b.Property<int?>("TratamientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TratamientoId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NombreMedicamento")
                        .HasColumnType("int");

                    b.Property<string>("Posologia")
                        .HasColumnType("text");

                    b.Property<int?>("TratamientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TratamientoId");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Documento")
                        .HasColumnType("text");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Remision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime");

                    b.Property<string>("Resultado")
                        .HasColumnType("text");

                    b.Property<int>("TipoExamen")
                        .HasColumnType("int");

                    b.Property<int?>("TratamientoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TratamientoId");

                    b.ToTable("Remisiones");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("TipoSigno")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Tratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Incapacidad")
                        .HasColumnType("int");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tratamientos");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Enfermera", b =>
                {
                    b.HasBaseType("HospiEnCasa.App.Dominio.Entidades.Persona");

                    b.Property<string>("HorasLaborales")
                        .HasColumnType("text");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Enfermera");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.FamiliarDesignado", b =>
                {
                    b.HasBaseType("HospiEnCasa.App.Dominio.Entidades.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("text");

                    b.Property<string>("Parentesco")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("FamiliarDesignado");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Medico", b =>
                {
                    b.HasBaseType("HospiEnCasa.App.Dominio.Entidades.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("text");

                    b.Property<string>("RegistroMedico")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Paciente", b =>
                {
                    b.HasBaseType("HospiEnCasa.App.Dominio.Entidades.Persona");

                    b.Property<int?>("EnfermeraId")
                        .HasColumnType("int");

                    b.Property<int?>("FamiliarDesignadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<double>("Latitud")
                        .HasColumnType("double");

                    b.Property<double>("Longitud")
                        .HasColumnType("double");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PlanMedico")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasIndex("EnfermeraId");

                    b.HasIndex("FamiliarDesignadoId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("MedicoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.HistoriaClinica", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Tratamiento", "Tratamiento")
                        .WithMany()
                        .HasForeignKey("TratamientoId");

                    b.Navigation("Tratamiento");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Medicamento", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Tratamiento", null)
                        .WithMany("Medicamentos")
                        .HasForeignKey("TratamientoId");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Remision", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Tratamiento", null)
                        .WithMany("Remisiones")
                        .HasForeignKey("TratamientoId");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.SignoVital", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Paciente", null)
                        .WithMany("SignosVitales")
                        .HasForeignKey("PacienteId");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Paciente", b =>
                {
                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Enfermera", "Enfermera")
                        .WithMany()
                        .HasForeignKey("EnfermeraId");

                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.FamiliarDesignado", "FamiliarDesignado")
                        .WithMany()
                        .HasForeignKey("FamiliarDesignadoId");

                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.HistoriaClinica", "HistoriaClinica")
                        .WithMany()
                        .HasForeignKey("HistoriaClinicaId");

                    b.HasOne("HospiEnCasa.App.Dominio.Entidades.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.Navigation("Enfermera");

                    b.Navigation("FamiliarDesignado");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Tratamiento", b =>
                {
                    b.Navigation("Medicamentos");

                    b.Navigation("Remisiones");
                });

            modelBuilder.Entity("HospiEnCasa.App.Dominio.Entidades.Paciente", b =>
                {
                    b.Navigation("SignosVitales");
                });
#pragma warning restore 612, 618
        }
    }
}
