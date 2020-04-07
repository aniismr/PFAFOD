using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
namespace BackEnd.Data{
    public class dbContext: DbContext{
            public dbContext(DbContextOptions options) : base(options) { }

        public DbSet<Candidat> Candidat {get;set;}
        public DbSet<Candidature> Candidature {get;set;}
        public DbSet<CompetenceCandidature> CompetenceCandidaure {get;set;}
        public DbSet<Competence> Competence{get;set;}
        public DbSet<User> User {get;set;}
        public DbSet<Question> Question { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<TestCategorie> TestCategorie { get; set; }
        public DbSet<TestCandidature> TestCandidature { get; set; }

    }
}