using Microsoft.EntityFrameworkCore;
using FodApi.Model;
namespace FodApi.Data
{
    public class FodContext : DbContext {
    public FodContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Candidat>().Property(p => p.id_candidat).HasMaxLength(40);
        builder.Entity<Candidature>().Property(p => p.id_candidature).HasMaxLength(40);
        builder.Entity<Competence>().Property(p => p.id_competence).HasMaxLength(40);

        builder.Entity<Candidat>().ToTable("Candidat");
        builder.Entity<Candidature>().ToTable("Candidature");
        builder.Entity<Competence>().ToTable("Competence");
    }

    public DbSet<Candidat> Candidats { get; set; }
    public DbSet<Candidature> Candidatures { get; set; }
    public DbSet<Competence> Competences { get; set; }
}

}