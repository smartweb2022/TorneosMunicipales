﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disiplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EscuelaArbitroId")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EscuelaArbitroId");

                    b.HasIndex("TorneoId");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("Dominio.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Diciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EscenarioId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Medidas")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Dominio.Deportista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apelldos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroEmergencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Deportistas");
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisciplinaDeportiva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId")
                        .IsUnique();

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadDeportistas")
                        .HasColumnType("int");

                    b.Property<string>("Disciplina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatrocinadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatrocinadorId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Dominio.Escenario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TorneoId");

                    b.ToTable("Escenarios");
                });

            modelBuilder.Entity("Dominio.EscuelaArbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolucion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EscuelaArbitros");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patrocinadores");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("EquipoId", "TorneoId");

                    b.HasIndex("TorneoId");

                    b.ToTable("TorneoEquipos");
                });

            modelBuilder.Entity("Dominio.Arbitro", b =>
                {
                    b.HasOne("Dominio.EscuelaArbitro", null)
                        .WithMany("Arbitros")
                        .HasForeignKey("EscuelaArbitroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Torneo", null)
                        .WithMany("Arbitros")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Deportista", b =>
                {
                    b.HasOne("Dominio.Equipo", null)
                        .WithMany("Deportista")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.HasOne("Dominio.Equipo", null)
                        .WithOne("Entrenador")
                        .HasForeignKey("Dominio.Entrenador", "EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.HasOne("Dominio.Patrocinador", null)
                        .WithMany("Equipos")
                        .HasForeignKey("PatrocinadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Escenario", b =>
                {
                    b.HasOne("Dominio.Torneo", null)
                        .WithMany("Escenarios")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.HasOne("Dominio.Municipio", null)
                        .WithMany("Torneos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.HasOne("Dominio.Equipo", "Equipo")
                        .WithMany("TorneoEquipos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Torneo", "Torneo")
                        .WithMany("TorneoEquipos")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Navigation("Deportista");

                    b.Navigation("Entrenador");

                    b.Navigation("TorneoEquipos");
                });

            modelBuilder.Entity("Dominio.EscuelaArbitro", b =>
                {
                    b.Navigation("Arbitros");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Navigation("Torneos");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Navigation("Arbitros");

                    b.Navigation("Escenarios");

                    b.Navigation("TorneoEquipos");
                });
#pragma warning restore 612, 618
        }
    }
}
