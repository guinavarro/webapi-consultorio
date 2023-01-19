﻿// <auto-generated />
using System;
using Consultorio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consultorio.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20221025194310_RetirandoAvisosMigrations")]
    partial class RetirandoAvisosMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Consultorio.Models.Entities.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHorario")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_horario");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int")
                        .HasColumnName("id_especialidade");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int")
                        .HasColumnName("id_paciente");

                    b.Property<decimal>("Preco")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)")
                        .HasColumnName("preco");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("int")
                        .HasColumnName("id_profissional");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("tb_consulta");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit")
                        .HasColumnName("ativa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_especialidade");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("celular");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_paciente");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_profissional");
                });

            modelBuilder.Entity("EspecialidadeProfissional", b =>
                {
                    b.Property<int>("EspecialidadesId")
                        .HasColumnType("int");

                    b.Property<int>("ProfissionaisId")
                        .HasColumnType("int");

                    b.HasKey("EspecialidadesId", "ProfissionaisId");

                    b.HasIndex("ProfissionaisId");

                    b.ToTable("EspecialidadeProfissional");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Consulta", b =>
                {
                    b.HasOne("Consultorio.Models.Entities.Especialidade", "Especialidade")
                        .WithMany("Consultas")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entities.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entities.Profissional", "Profissional")
                        .WithMany("Consultas")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Paciente");

                    b.Navigation("Profissional");
                });

            modelBuilder.Entity("EspecialidadeProfissional", b =>
                {
                    b.HasOne("Consultorio.Models.Entities.Especialidade", null)
                        .WithMany()
                        .HasForeignKey("EspecialidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entities.Profissional", null)
                        .WithMany()
                        .HasForeignKey("ProfissionaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Especialidade", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Consultorio.Models.Entities.Profissional", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}