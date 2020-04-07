﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20200331175942_buildOne")]
    partial class buildOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
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

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatureID");

                    b.HasIndex("CandidatID");

                    b.HasIndex("TestId");

                    b.ToTable("Candidature");
                });

            modelBuilder.Entity("BackEnd.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("libelle")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorie");
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

            modelBuilder.Entity("BackEnd.Models.CompetenceCandidature", b =>
                {
                    b.Property<int>("CompetenceCandidatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatureID")
                        .HasColumnType("int");

                    b.Property<int>("CompetenceID")
                        .HasColumnType("int");

                    b.HasKey("CompetenceCandidatureID");

                    b.HasIndex("CandidatureID");

                    b.HasIndex("CompetenceID");

                    b.ToTable("CompetenceCandidaure");
                });

            modelBuilder.Entity("BackEnd.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("ennonce")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("rep1")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("rep2")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("rep3")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("reptrue")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("QuestionId");

                    b.HasIndex("CategorieID");

                    b.HasIndex("TestId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("BackEnd.Models.TestCandidat", b =>
                {
                    b.Property<int>("TestCandidatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidatureID")
                        .HasColumnType("int");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.Property<string>("score")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TestCandidatID");

                    b.HasIndex("CandidatureID");

                    b.HasIndex("TestID");

                    b.ToTable("testCandidat");
                });

            modelBuilder.Entity("BackEnd.Models.TestQuestion", b =>
                {
                    b.Property<int>("TestQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.HasKey("TestQuestionID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("TestID");

                    b.ToTable("TestQuestion");
                });

            modelBuilder.Entity("BackEnd.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BackEnd.Models.test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("heure")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nbcandidat")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TestId");

                    b.ToTable("test");
                });

            modelBuilder.Entity("BackEnd.Models.Candidature", b =>
                {
                    b.HasOne("BackEnd.Models.Candidat", "Candidat")
                        .WithMany("Candidatures")
                        .HasForeignKey("CandidatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.test", null)
                        .WithMany("Candidature")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("BackEnd.Models.CompetenceCandidature", b =>
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

            modelBuilder.Entity("BackEnd.Models.Question", b =>
                {
                    b.HasOne("BackEnd.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("BackEnd.Models.TestCandidat", b =>
                {
                    b.HasOne("BackEnd.Models.Candidature", "Candidature")
                        .WithMany()
                        .HasForeignKey("CandidatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.test", "Test")
                        .WithMany()
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackEnd.Models.TestQuestion", b =>
                {
                    b.HasOne("BackEnd.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.test", "Test")
                        .WithMany()
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
