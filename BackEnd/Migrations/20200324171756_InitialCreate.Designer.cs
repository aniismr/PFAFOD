﻿// <auto-generated />
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20200324171756_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Models.Candidat", b =>
                {
                    b.Property<int>("CandidatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CandidatNom")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CandidatPrenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DateDeNaissance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CandidatId");

                    b.ToTable("Candidat");
                });

            modelBuilder.Entity("BackEnd.Models.Candidature", b =>
                {
                    b.Property<int>("CandidatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidatID")
                        .HasColumnType("int");

                    b.Property<string>("DatePostulation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reponse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatureID");

                    b.HasIndex("CandidatID");

                    b.ToTable("Candidature");
                });

            modelBuilder.Entity("BackEnd.Models.Competence", b =>
                {
                    b.Property<int>("CompetenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompetenceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompetenceID");

                    b.ToTable("Competence");
                });

            modelBuilder.Entity("BackEnd.Models.CompetenceCandidaure", b =>
                {
                    b.Property<int>("CompetenceCandidaureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatureID")
                        .HasColumnType("int");

                    b.Property<int>("CompetenceID")
                        .HasColumnType("int");

                    b.HasKey("CompetenceCandidaureID");

                    b.HasIndex("CandidatureID");

                    b.HasIndex("CompetenceID");

                    b.ToTable("CompetenceCandidaure");
                });

            modelBuilder.Entity("BackEnd.Models.Candidature", b =>
                {
                    b.HasOne("BackEnd.Models.Candidat", "Candidat")
                        .WithMany("Candidatures")
                        .HasForeignKey("CandidatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Models.CompetenceCandidaure", b =>
                {
                    b.HasOne("BackEnd.Models.Candidature", "Candidature")
                        .WithMany("CompetenceCandidature")
                        .HasForeignKey("CandidatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Competence", "Competence")
                        .WithMany()
                        .HasForeignKey("CompetenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
