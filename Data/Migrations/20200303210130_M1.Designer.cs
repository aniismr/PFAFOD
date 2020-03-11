﻿// <auto-generated />
using System;
using FodApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FodApi.Data.Migrations
{
    [DbContext(typeof(FodContext))]
    [Migration("20200303210130_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FodApi.Model.Candidat", b =>
                {
                    b.Property<int>("id_candidat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(40)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cv")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("datenaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id_candidat");

                    b.ToTable("Candidat");
                });

            modelBuilder.Entity("FodApi.Model.Candidature", b =>
                {
                    b.Property<int>("id_candidature")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(40)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Candidatid_candidat")
                        .HasColumnType("int");

                    b.Property<DateTime>("datecandidature")
                        .HasColumnType("datetime2");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id_candidature");

                    b.HasIndex("Candidatid_candidat");

                    b.ToTable("Candidature");
                });

            modelBuilder.Entity("FodApi.Model.Competence", b =>
                {
                    b.Property<string>("id_competence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(40);

                    b.Property<int?>("Candidatureid_candidature")
                        .HasColumnType("int");

                    b.Property<string>("libele")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id_competence");

                    b.HasIndex("Candidatureid_candidature");

                    b.ToTable("Competence");
                });

            modelBuilder.Entity("FodApi.Model.Candidature", b =>
                {
                    b.HasOne("FodApi.Model.Candidat", null)
                        .WithMany("candidature")
                        .HasForeignKey("Candidatid_candidat");
                });

            modelBuilder.Entity("FodApi.Model.Competence", b =>
                {
                    b.HasOne("FodApi.Model.Candidature", null)
                        .WithMany("competences")
                        .HasForeignKey("Candidatureid_candidature");
                });
#pragma warning restore 612, 618
        }
    }
}
