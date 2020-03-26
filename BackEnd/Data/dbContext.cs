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
        public DbSet<test> test { get; set; }
        public DbSet<TestQuestion> TestQuestion { get; set; }
        public DbSet<TestCandidat> testCandidat { get; set; }

    }
}