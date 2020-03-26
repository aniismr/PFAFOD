using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
namespace BackEnd.Data{
    public class dbContext: DbContext{
            public dbContext(DbContextOptions options) : base(options) { }

        public DbSet<Candidat> Candidat {get;set;}
        public DbSet<Candidature> Candidature {get;set;}
        public DbSet<CompetenceCandidature> CompetenceCandidaure {get;set;}
        public DbSet<Competence> Competence{get;set;}


    }
}