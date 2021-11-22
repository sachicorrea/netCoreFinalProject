﻿// <auto-generated />
using System;
using Hospital.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospital.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospital.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numerotelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Hospital.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("Hospital.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("Hospital.App.Dominio.Persona");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroMedico")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Hospital.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("Hospital.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.HasIndex("MedicoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Hospital.App.Dominio.SignoVital", b =>
                {
                    b.HasOne("Hospital.App.Dominio.Paciente", "Paciente")
                        .WithMany("SignosVitales")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Hospital.App.Dominio.Paciente", b =>
                {
                    b.HasOne("Hospital.App.Dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Hospital.App.Dominio.Paciente", b =>
                {
                    b.Navigation("SignosVitales");
                });
#pragma warning restore 612, 618
        }
    }
}
